using ForkFinder.Data;
using ForkFinder.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ForkFinder.Controllers
{
    [AllowAnonymous]
    public class ClientesController : Controller
    {
        private readonly AppDbContext _context;

        public ClientesController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _context.Clientes.ToListAsync();
            return View(data);
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register([Bind("Id,Email,Senha,Nome,CPF,Papel,CreatedDate")] Cliente cliente)
        {
            var checkExistingEmail = await _context.Clientes.FirstOrDefaultAsync(stored => stored.Email == cliente.Email);
            var checkExistingNome = await _context.Clientes.FirstOrDefaultAsync(stored => stored.Nome == cliente.Nome);
            var validatePasswordLength = cliente.Senha.Length >= 8;

            if (checkExistingEmail != null)
            {
                ModelState.AddModelError("Email", "E-mail já cadastrado.");
            }

            if (checkExistingNome != null)
            {
                ModelState.AddModelError("Nome", "Nome já cadastrado.");
            }

            if (!validatePasswordLength)
            {
                ModelState.AddModelError("Senha", "A senha deve ter pelo menos 8 caracteres.");
            }

            if (ModelState.IsValid || (!string.IsNullOrEmpty(cliente.Senha)))
            {
                cliente.Senha = BCrypt.Net.BCrypt.HashPassword(cliente.Senha);
                cliente.Nome = cliente.Nome;
                cliente.Email = cliente.Email;
                cliente.CPF = cliente.CPF;
                cliente.Foto = "#";
                cliente.Papel = (Papel)0;
                _context.Add(cliente);
                await _context.SaveChangesAsync();
                return RedirectToAction("Login", "Clientes");
            }

            return View();
        }

        [AllowAnonymous]
        public async Task<IActionResult> Reserved(int id)
        {
            var reservas = await _context.Clientes
                .Include(c => c.Reservas)
                .ThenInclude(r => r.Mesa)
                .FirstOrDefaultAsync(c => c.ClienteId == id);

            if (reservas == null)
            {
                return NotFound();
            }

            return View(reservas);
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login([Bind("Email,Senha")] Cliente cliente)
        {
            var user = await _context.Clientes
                .FirstOrDefaultAsync(m => m.Email == cliente.Email);

            if (user == null)
            {
                ViewBag.Message = "Usuário e/ou Senha inválidos!";
                return View();
            }

            bool isSenhaOk = BCrypt.Net.BCrypt.Verify(cliente.Senha, user.Senha);

            if (isSenhaOk)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.Nome),
                    new Claim(ClaimTypes.NameIdentifier, user.Nome),
                    new Claim(ClaimTypes.Role, user.Papel.ToString()),
                    new Claim("ClienteId", user.ClienteId.ToString()),
                };

                var userIdentity = new ClaimsIdentity(claims, "login");

                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);

                var props = new AuthenticationProperties
                {
                    AllowRefresh = true,
                    ExpiresUtc = DateTime.Now.ToLocalTime().AddDays(7),
                    IsPersistent = true
                };

                await HttpContext.SignInAsync(principal, props);

                return Redirect("/");

            }

            ViewBag.Message = "Usuário e/ou Senha inválidos!";
            return View();
        }

        [AllowAnonymous]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Login", "Clientes");
        }

        public async Task<IActionResult> Reserva(int? especialidadeId, int? restauranteId)
        {
            var clienteId = GetSessionClienteId();

            var reservas = _context.Reservas
                .Include(r => r.Agenda)
                .Include(r => r.Mesa)
                .Where(r => r.ClienteId == clienteId);

            if (especialidadeId.HasValue)
            {
                reservas = reservas.Where(r => r.EspecialidadeId == especialidadeId);
            }

            if (restauranteId.HasValue)
            {
                reservas = reservas.Where(r => r.RestauranteId == restauranteId);
            }

            ViewBag.Especialidades = await _context.Especialidades.ToListAsync();
            ViewBag.Restaurantes = await _context.Restaurantes.ToListAsync();

            return View(await reservas.ToListAsync());
        }

        public async Task<IActionResult> Detalhes(int reservaId)
        {
            var clienteId = GetSessionClienteId();

            var reserva = await _context.Reservas
                .Include(r => r.Agenda)
                .Include(r => r.Mesa)
                .FirstOrDefaultAsync(r => r.Id == reservaId && r.ClienteId == clienteId);

            if (reserva == null)
            {
                return NotFound();
            }

            var detalhesReserva = new
            {
                Data = reserva.Agenda.Data.ToShortDateString(),
                Horario = reserva.Horario,
                Descricao = reserva.Descricao,
                TamanhoMesa = reserva.Mesa.TamanhoMesa,
                DataCriacao = reserva.DataHoraCriacao.ToShortDateString()
            };

            return Json(detalhesReserva);
        }

        [HttpPost]
        public async Task<IActionResult> Cancelar(int reservaId)
        {
            var clienteId = GetSessionClienteId();

            var reserva = await _context.Reservas
                .FirstOrDefaultAsync(r => r.Id == reservaId && r.ClienteId == clienteId);

            if (reserva == null)
            {
                return NotFound();
            }

            if (reserva.Agenda.Data.AddDays(-1) <= DateTime.Now)
            {
                return BadRequest("A reserva não pode ser cancelada com menos de 24 horas de antecedência.");
            }

            _context.Reservas.Remove(reserva);
            await _context.SaveChangesAsync();

            return Ok();
        }

        private int GetSessionClienteId()
        {
            var clienteIdClaim = User.FindFirstValue("ClienteId");
            return int.Parse(clienteIdClaim);
        }
    }
}

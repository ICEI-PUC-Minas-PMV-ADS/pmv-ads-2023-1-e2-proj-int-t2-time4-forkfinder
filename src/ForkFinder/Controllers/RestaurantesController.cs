using ForkFinder.Data;
using ForkFinder.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using ForkFinder.ViewModels;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace ForkFinder.Controllers
{
    public class RestaurantesController : Controller
    {
        private readonly AppDbContext _context;
        public RestaurantesController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _context.Restaurantes
                .Include(a => a.Avaliacoes)
                .Include(e => e.Endereco)
                .Include(er => er.Especialidades_Restaurantes).ThenInclude(es => es.Especialidade)
                .ToListAsync();

            return View(data);
        }

        [AllowAnonymous]
        public async Task<IActionResult> Agenda(int id)
        {
            var restaurante = await _context.Restaurantes
                .Include(r => r.Agendas)
                .FirstOrDefaultAsync(n => n.RestauranteId == id);

            if (restaurante == null)
            {
                return NotFound();
            }

            var viewModel = new AgendaViewModel
            {

            };

            return View(viewModel);
        }


        [AllowAnonymous]
        public async Task<IActionResult> Restaurante(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var restaurante = await _context.Restaurantes
                .Include(f => f.Fotos)
                .Include(r => r.Avaliacoes)
                //.Include(r => r.Agendas)
                .FirstOrDefaultAsync(r => r.RestauranteId == id);
            if (restaurante == null)
            {
                return NotFound();
            }

            return View(restaurante);


        }
        [AllowAnonymous]
        public async Task<IActionResult> Mesas(int id)
        {
            var restaurante = await _context.Restaurantes
                .Include(m => m.Mesas).ThenInclude(ho => ho.Horarios)
                .Include(r => r.Agendas).ThenInclude(ho => ho.Horarios)
                .FirstOrDefaultAsync(n => n.RestauranteId == id);
            if (restaurante == null)
            {
                return NotFound();
            }

            return View(restaurante);
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Register([Bind("Id,Email,Senha,Nome,CNPJ,Papel,CreatedDate")] Restaurante restaurante)
        {
            var checkExistingEmail = _context.Restaurantes.FirstOrDefault(stored => stored.Email == restaurante.Email);
            var validatePasswordLength = restaurante.Senha.Length >= 8;


            if (checkExistingEmail != null)
            {
                ModelState.AddModelError("Email", "E-mai já cadastrado");
            }

            if (!validatePasswordLength)
            {
                ModelState.AddModelError("Senha", "A senha deve ter pelo menos 8 caracteres.");
            }
            if (ModelState.IsValid)
            {
                //string iconPath = "path/do/icone/user.png"; // Caminho do arquivo de imagem do ícone
                //byte[] iconBytes = File.ReadAllBytes(iconPath);

                restaurante.Senha = BCrypt.Net.BCrypt.HashPassword(restaurante.Senha);
                restaurante.Nome = restaurante.Nome;
                restaurante.Email = restaurante.Email;
                restaurante.CNPJ = restaurante.CNPJ;
                //restaurante.FotoPerfil = iconBytes;
                restaurante.Papel = (Papel)1;
                _context.Add(restaurante);
                await _context.SaveChangesAsync();
                return RedirectToAction("Perfil", restaurante);
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> EditarPerfil(Restaurante restaurante, IFormFile fotoPerfil)
        {
            if (ModelState.IsValid)
            {
                // Atualizar os campos do restaurante com os dados do formulário
                var restauranteExistente = await _context.Restaurantes.FindAsync(restaurante.RestauranteId);

                if (restauranteExistente != null)
                {
                    restauranteExistente.CNPJ = restaurante.CNPJ;
                    restauranteExistente.DescricaoRestaurante = restaurante.DescricaoRestaurante;
                    restauranteExistente.Acessibilidade = restaurante.Acessibilidade;

                    if (fotoPerfil != null)
                    {
                        // Processar e salvar a imagem de perfil
                        restauranteExistente.FotoPerfil = await ProcessarImagemPerfil(fotoPerfil);
                    }

                    _context.Update(restauranteExistente);
                    await _context.SaveChangesAsync();

                    return RedirectToAction("EditarPerfil", new { id = restauranteExistente.RestauranteId });
                }
            }

            return View(restaurante);
        }

        private async Task<byte[]> ProcessarImagemPerfil(IFormFile fotoPerfil)
        {
            using (var memoryStream = new MemoryStream())
            {
                await fotoPerfil.CopyToAsync(memoryStream);
                return memoryStream.ToArray();
            }
        }


        [HttpPost]
        public async Task<IActionResult> PreencherPerfil(Restaurante restaurante, IFormFile fotoPerfilFile)
        {
            if (fotoPerfilFile != null)
            {
                using (var memoryStream = new MemoryStream())
                {
                    await fotoPerfilFile.CopyToAsync(memoryStream);
                    restaurante.FotoPerfil = memoryStream.ToArray();
                }
            }

            // Salvar o objeto Restaurante no banco de dados
            _context.Restaurantes.Add(restaurante);
            await _context.SaveChangesAsync();

            // Redirecionar para a página de sucesso ou outra página relevante
            return RedirectToAction("Index");
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login([Bind("Email,Senha")] Restaurante restaurante)
        {
            var user = await _context.Restaurantes.FirstOrDefaultAsync(m => m.Email == restaurante.Email);

            if (user == null)
            {
                ModelState.AddModelError(string.Empty, "Usuário e/ou senha inválidos.");
                return View();
            }

            bool isSenhaOk = BCrypt.Net.BCrypt.Verify(restaurante.Senha, user.Senha);

            if (isSenhaOk)
            {
                var claims = new List<Claim>
        {
            new Claim(ClaimTypes.Name, user.Nome),
            new Claim(ClaimTypes.NameIdentifier, user.Nome),
            new Claim(ClaimTypes.Role, user.Papel.ToString()),
            new Claim("RestauranteId", user.RestauranteId.ToString()),
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

            ModelState.AddModelError(string.Empty, "Usuário e/ou senha inválidos.");
            return View();
        }

        [AllowAnonymous]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Login", "Restaurantes");
        }
        [Authorize]
        public async Task<IActionResult> Reserva(int mesaId, DateTime horarioId, DateTime dataReserva, int clienteId, int agendaId)
        {
            var reserva = new Reserva
            {
                MesaId = mesaId,
                DataHoraReserva = horarioId,
                ClienteId = int.Parse(User.FindFirstValue("ClienteId")),
                DataHoraCriacao = DateTime.Now,
                //AgendaId = agendaId,
                Situacao = false // Define a reserva como não aprovada inicialmente
            };

            var cliente = _context.Clientes.Find(clienteId);
            if (cliente != null)
            {
                cliente.Reservas.Add(reserva);
            }

            _context.Add(reserva);
            await _context.SaveChangesAsync();

            return RedirectToAction("Reserved", "Clientes", new { id = clienteId });
        }

    }

}

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
                .Include(er => er.Especialidades_Restaurantes).ThenInclude(es => es.Especialidade)
                .ToListAsync();

            return View(data);
        }
        /*[AllowAnonymous]
        public async Task<IActionResult> Index(int id)
        {
            var restaurante = await _context.Restaurantes
                .Include(am => am.Especialidades_Restaurantes).ThenInclude(r => r.Restaurante)
                .Include(am => am.Especialidades_Restaurantes).ThenInclude(r => r.Restaurante).ThenInclude(e => e.Endereco)
                .Include(am => am.Especialidades_Restaurantes).ThenInclude(r => r.Restaurante).ThenInclude(a => a.Avaliacoes)
                .FirstOrDefaultAsync(n => n.RestauranteId == id);
            if (restaurante == null)
            {
                return NotFound();
            }

            return View(restaurante);
        }*/

        [AllowAnonymous]
        public async Task<IActionResult> Agenda(int id)
        {
            var restaurante = await _context.Restaurantes
                .Include(r => r.Agendas).ThenInclude(d=>d.DataMesas)
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
                .Include(m => m.Mesas)
                .Include(r => r.Agendas)
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
                restaurante.Senha = BCrypt.Net.BCrypt.HashPassword(restaurante.Senha);
                restaurante.Nome = restaurante.Nome;
                restaurante.Email = restaurante.Email;
                restaurante.CNPJ = restaurante.CNPJ;
                restaurante.FotoPerfil = "#";
                restaurante.Papel = (Papel)1;
                _context.Add(restaurante);
                await _context.SaveChangesAsync();
                return RedirectToAction("Login", "Restaurantes");
            }
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login([Bind("Email,Senha")] Restaurante restaurante)
        {
            var user = await _context.Restaurantes
                .FirstOrDefaultAsync(m => m.Email == restaurante.Email);

            if (user == null)
            {
                ViewBag.Message = "Usuário e/ou Senha inválidos!";
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

            ViewBag.Message = "Usuário e/ou Senha inválidos!";
            return View();

        }
        [AllowAnonymous]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Login", "Restaurantes");
        }
    }
}
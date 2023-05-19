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
            var checkExistingEmail = _context.Clientes.FirstOrDefault(stored => stored.Email == cliente.Email);
            var validatePasswordLength = cliente.Senha.Length >= 8;
            

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
                cliente.Senha = BCrypt.Net.BCrypt.HashPassword(cliente.Senha);
                cliente.Nome = cliente.Nome;
                cliente.Email = cliente.Email;
                cliente.CPF = cliente.CPF;
                cliente.Foto = "#";
                cliente.Papel = 0;
                _context.Add(cliente);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        private bool ClienteExists(int id)
        {
            return _context.Clientes.Any(e => e.Id == id);
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
                        new Claim("Id", user.Id.ToString()),
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
    }
}

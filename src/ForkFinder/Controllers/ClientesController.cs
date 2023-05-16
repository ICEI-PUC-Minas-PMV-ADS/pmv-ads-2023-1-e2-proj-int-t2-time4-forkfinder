using ForkFinder.Data;
using ForkFinder.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
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
        public async Task<IActionResult> Register([Bind("Id,Email,Senha,CreatedDate")] Cliente cliente)
        {
            var checkExistingEmail = _context.Clientes.FirstOrDefault(stored => stored.Email == cliente.Email);
            var validatePasswordLength = cliente.Senha.Length >= 8;
            

            if (checkExistingEmail != null)
            {
                ModelState.AddModelError("email", "E-mai já cadastrado");
            }

            if (!validatePasswordLength)
            {
                ModelState.AddModelError("password", "A senha deve ter pelo menos 8 caracteres.");
            }
            if (ModelState.IsValid)
            {
                cliente.Senha = BCrypt.Net.BCrypt.HashPassword(cliente.Senha);
                cliente.Nome = cliente.Email;
                cliente.Foto = "#";
                _context.Add(cliente);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Home");
            }
            return View(cliente);
        }

        private bool ClienteExists(int id)
        {
            return _context.Clientes.Any(e => e.Id == id);
        }
    }
}

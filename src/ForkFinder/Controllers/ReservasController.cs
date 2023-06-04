using ForkFinder.Data;
using ForkFinder.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ForkFinder.Controllers
{
    public class ReservasController : Controller
    {
        private readonly AppDbContext _context;
        public ReservasController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _context.Reservas.ToListAsync();
            return View(data);
        }
        public IActionResult Reservar()
        {
            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Reservar([Bind("DataHoraReserva,Descricao")] Reserva reserva,Mesa mesa, Restaurante restaurante)
        {
            if (ModelState.IsValid)
            {
               
                reserva.DataHoraCriacao = DateTime.Now;                
                reserva.Situacao = false;
                reserva.MesaId = mesa.Id;
                reserva.ClienteId = int.Parse(User.FindFirstValue("ClienteId"));
                _context.Add(reserva);
                await _context.SaveChangesAsync();
                return RedirectToAction("Reserved", "Clientes");
            }
            return View();
        }
    }
}

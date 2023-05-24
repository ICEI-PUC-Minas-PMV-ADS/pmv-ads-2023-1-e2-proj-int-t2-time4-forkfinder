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
            /*var data = await _context.Reservas.Include(n => n.Cliente).ToListAsync();
            var clientesList = db.Clientes.Include(u => u.Mesas);
            return View(await Clientes.ToListAsync());*/
            return View(data);
        }
        public IActionResult Reservar()
        {
            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Reservar([Bind("DataHoraReserva,Descricao,ClienteId")] Reserva reserva,Mesa mesa,Cliente cliente)
        {
            /*if (ModelState.IsValid)
            {*/
               
                reserva.DataHoraCriacao = DateTime.Now;                
                reserva.Situacao = false;
                reserva.ClienteId = cliente.Id;
                reserva.MesaId = mesa.Id;
                

                _context.Add(reserva);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            /*}
            return View();*/
        }
    }
}

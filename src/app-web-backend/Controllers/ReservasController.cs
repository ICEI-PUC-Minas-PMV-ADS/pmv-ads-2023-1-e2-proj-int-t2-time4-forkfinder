using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using fork_finder.Data;
using fork_finder.Models;

namespace fork_finder.Controllers
{
    public class ReservasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ReservasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: RestauranteReservas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Reservas.ToListAsync());
        }

        // GET: RestauranteReservas/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var restauranteReserva = await _context.Reservas
                .FirstOrDefaultAsync(m => m.ClienteId == id);
            if (restauranteReserva == null)
            {
                return NotFound();
            }

            return View(restauranteReserva);
        }

        // GET: RestauranteReservas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: RestauranteReservas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RestauranteReservaId,DataHoraCriacao,DataHoraReserva,Descricao,Situacao,DataHoraReserva,Descricao")] Reserva restauranteReserva)
        {
            if (ModelState.IsValid)
            {
                restauranteReserva.ClienteId = Guid.NewGuid();
                _context.Add(restauranteReserva);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(restauranteReserva);
        }

        // GET: RestauranteReservas/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var restauranteReserva = await _context.Reservas.FindAsync(id);
            if (restauranteReserva == null)
            {
                return NotFound();
            }
            return View(restauranteReserva);
        }

        // POST: RestauranteReservas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("RestauranteReservaId,DataHoraCriacao,DataHoraReserva,Descricao,Situacao")] Reserva restauranteReserva)
        {
            if (id != restauranteReserva.ClienteId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(restauranteReserva);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RestauranteReservaExists(restauranteReserva.ClienteId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(restauranteReserva);
        }

        // GET: RestauranteReservas/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var restauranteReserva = await _context.Reservas
                .FirstOrDefaultAsync(m => m.ClienteId == id);
            if (restauranteReserva == null)
            {
                return NotFound();
            }

            return View(restauranteReserva);
        }

        // POST: RestauranteReservas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var restauranteReserva = await _context.Reservas.FindAsync(id);
            _context.Reservas.Remove(restauranteReserva);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RestauranteReservaExists(Guid id)
        {
            return _context.Reservas.Any(e => e.ClienteId == id);
        }
    }
}

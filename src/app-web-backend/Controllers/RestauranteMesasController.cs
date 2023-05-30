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
    public class RestauranteMesasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RestauranteMesasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: RestauranteMesas
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.RestauranteMesas.Include(r => r.RestauranteReserva);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: RestauranteMesas/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var restauranteMesa = await _context.RestauranteMesas
                .Include(r => r.RestauranteReserva)
                .FirstOrDefaultAsync(m => m.RestauranteMesaId == id);
            if (restauranteMesa == null)
            {
                return NotFound();
            }

            return View(restauranteMesa);
        }

        // GET: RestauranteMesas/Create
        public IActionResult Create()
        {
            ViewData["RestauranteReservaId"] = new SelectList(_context.RestauranteReservas, "RestauranteReservaId", "RestauranteReservaId");
            return View();
        }

        // POST: RestauranteMesas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RestauranteMesaId,QuantidadeMesa,TamanhoMesa,RestauranteReservaId")] RestauranteMesa restauranteMesa)
        {
            if (ModelState.IsValid)
            {
                restauranteMesa.RestauranteMesaId = Guid.NewGuid();
                _context.Add(restauranteMesa);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["RestauranteReservaId"] = new SelectList(_context.RestauranteReservas, "RestauranteReservaId", "RestauranteReservaId", restauranteMesa.RestauranteReservaId);
            return View(restauranteMesa);
        }

        // GET: RestauranteMesas/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var restauranteMesa = await _context.RestauranteMesas.FindAsync(id);
            if (restauranteMesa == null)
            {
                return NotFound();
            }
            ViewData["RestauranteReservaId"] = new SelectList(_context.RestauranteReservas, "RestauranteReservaId", "RestauranteReservaId", restauranteMesa.RestauranteReservaId);
            return View(restauranteMesa);
        }

        // POST: RestauranteMesas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("RestauranteMesaId,QuantidadeMesa,TamanhoMesa,RestauranteReservaId")] RestauranteMesa restauranteMesa)
        {
            if (id != restauranteMesa.RestauranteMesaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(restauranteMesa);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RestauranteMesaExists(restauranteMesa.RestauranteMesaId))
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
            ViewData["RestauranteReservaId"] = new SelectList(_context.RestauranteReservas, "RestauranteReservaId", "RestauranteReservaId", restauranteMesa.RestauranteReservaId);
            return View(restauranteMesa);
        }

        // GET: RestauranteMesas/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var restauranteMesa = await _context.RestauranteMesas
                .Include(r => r.RestauranteReserva)
                .FirstOrDefaultAsync(m => m.RestauranteMesaId == id);
            if (restauranteMesa == null)
            {
                return NotFound();
            }

            return View(restauranteMesa);
        }

        // POST: RestauranteMesas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var restauranteMesa = await _context.RestauranteMesas.FindAsync(id);
            _context.RestauranteMesas.Remove(restauranteMesa);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RestauranteMesaExists(Guid id)
        {
            return _context.RestauranteMesas.Any(e => e.RestauranteMesaId == id);
        }
    }
}

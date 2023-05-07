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
    public class RestaurantesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RestaurantesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Restaurantes
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Restaurantes.Include(r => r.Especialidade);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Restaurantes/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var restaurante = await _context.Restaurantes
                .Include(r => r.Produtos)
                .Include(r => r.Especialidade)
                .FirstOrDefaultAsync(m => m.RestauranteId == id);
            if (restaurante == null)
            {
                return NotFound();
            }

            return View(restaurante);
        }
        //Cardápio
                public async Task<IActionResult> Cardapio(Guid? id)
                {
                    if (id == null)
                    {
                        return NotFound();
            }

            var restaurante = await _context.Restaurantes
                .Include(r => r.Produtos)
                .Include(r => r.Especialidade)
                .FirstOrDefaultAsync(m => m.RestauranteId == id);
                    if (restaurante == null)
                    {
                        return NotFound();
        }

        return View(restaurante);
        }
        // GET: Restaurantes/Create
        public IActionResult Create()
        {
            ViewData["EspecialidadeId"] = new SelectList(_context.Especialidades, "EspecialidadeId", "NomeEspecialidade");
            return View();
        }

        // POST: Restaurantes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RestauranteId,CNPJ,FotoPerfil,DescricaoRestaurante,EspecialidadeId,Nome,Email,Senha,Telefone,Idioma,Papel")] Restaurante restaurante)
        {
            if (ModelState.IsValid)
            {
                restaurante.RestauranteId = Guid.NewGuid();
                restaurante.CreateDate = DateTime.Now;
                _context.Add(restaurante);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EspecialidadeId"] = new SelectList(_context.Especialidades, "EspecialidadeId", "NomeEspecialidade", restaurante.EspecialidadeId);
            return View(restaurante);
        }

        // Reserva
        /* public IActionResult Reserva()
         {
             ViewData["EspecialidadeId"] = new SelectList(_context.Especialidades, "EspecialidadeId", "ImagemUpload");
             return View();
         }*/
       /* public IActionResult Reserva()
        {
            return View();
        }

        // POST: Restaurantes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Reserva([Bind("RestauranteId,RestauranteReservaId,DataHoraReserva,DataHoraCriacao,ClienteId,")] Restaurante restaurante,RestauranteReserva restauranteReserva,Cliente cliente,RestauranteMesa restauranteMesa)
        {
            if (ModelState.IsValid)
            {   
                restauranteMesa.RestauranteMesaId = Guid.NewGuid();
                cliente.ClienteId = Guid.NewGuid();
                restauranteReserva.RestauranteReservaId = Guid.NewGuid();
                restauranteReserva.DataHoraCriacao = DateTime.Now;
                restaurante.RestauranteId = Guid.NewGuid();
                _context.Add(restaurante);
                _context.Add(restauranteReserva);
                _context.Add(cliente);
                _context.Add(restauranteMesa);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            
            return View(restaurante);
        }
*/
        // GET: Restaurantes/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var restaurante = await _context.Restaurantes.FindAsync(id);
            if (restaurante == null)
            {
                return NotFound();
            }
            ViewData["EspecialidadeId"] = new SelectList(_context.Especialidades, "EspecialidadeId", "NomeEspecialidade", restaurante.EspecialidadeId);
            return View(restaurante);
        }

        // POST: Restaurantes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("RestauranteId,CNPJ,FotoPerfil,DescricaoRestaurante,EspecialidadeId,Nome,Email,Senha,Telefone,Idioma,Papel")] Restaurante restaurante)
        {
            if (id != restaurante.RestauranteId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(restaurante);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RestauranteExists(restaurante.RestauranteId))
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
            ViewData["EspecialidadeId"] = new SelectList(_context.Especialidades, "EspecialidadeId", "NomeEspecialidade", restaurante.EspecialidadeId);
            return View(restaurante);
        }

        // GET: Restaurantes/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var restaurante = await _context.Restaurantes
                .Include(r => r.Especialidade)
                .FirstOrDefaultAsync(m => m.RestauranteId == id);
            if (restaurante == null)
            {
                return NotFound();
            }

            return View(restaurante);
        }

        // POST: Restaurantes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var restaurante = await _context.Restaurantes.FindAsync(id);
            _context.Restaurantes.Remove(restaurante);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RestauranteExists(Guid id)
        {
            return _context.Restaurantes.Any(e => e.RestauranteId == id);
        }
    }
}

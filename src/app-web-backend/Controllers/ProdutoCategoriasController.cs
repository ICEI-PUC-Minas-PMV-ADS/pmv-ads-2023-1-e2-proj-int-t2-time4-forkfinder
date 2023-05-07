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
    public class ProdutoCategoriasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProdutoCategoriasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ProdutoCategorias
        public async Task<IActionResult> Index()
        {
            return View(await _context.ProdutoCategorias.ToListAsync());
        }

        // GET: ProdutoCategorias/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produtoCategoria = await _context.ProdutoCategorias
                .FirstOrDefaultAsync(m => m.ProdutoCategoriaId == id);
            if (produtoCategoria == null)
            {
                return NotFound();
            }

            return View(produtoCategoria);
        }

        // GET: ProdutoCategorias/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ProdutoCategorias/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProdutoCategoriaId,Nome,Descricao,Imagem")] ProdutoCategoria produtoCategoria)
        {
            if (ModelState.IsValid)
            {
                produtoCategoria.ProdutoCategoriaId = Guid.NewGuid();
                _context.Add(produtoCategoria);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(produtoCategoria);
        }

        // GET: ProdutoCategorias/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produtoCategoria = await _context.ProdutoCategorias.FindAsync(id);
            if (produtoCategoria == null)
            {
                return NotFound();
            }
            return View(produtoCategoria);
        }

        // POST: ProdutoCategorias/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("ProdutoCategoriaId,Nome,Descricao,Imagem")] ProdutoCategoria produtoCategoria)
        {
            if (id != produtoCategoria.ProdutoCategoriaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(produtoCategoria);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProdutoCategoriaExists(produtoCategoria.ProdutoCategoriaId))
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
            return View(produtoCategoria);
        }

        // GET: ProdutoCategorias/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produtoCategoria = await _context.ProdutoCategorias
                .FirstOrDefaultAsync(m => m.ProdutoCategoriaId == id);
            if (produtoCategoria == null)
            {
                return NotFound();
            }

            return View(produtoCategoria);
        }

        // POST: ProdutoCategorias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var produtoCategoria = await _context.ProdutoCategorias.FindAsync(id);
            _context.ProdutoCategorias.Remove(produtoCategoria);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProdutoCategoriaExists(Guid id)
        {
            return _context.ProdutoCategorias.Any(e => e.ProdutoCategoriaId == id);
        }
    }
}

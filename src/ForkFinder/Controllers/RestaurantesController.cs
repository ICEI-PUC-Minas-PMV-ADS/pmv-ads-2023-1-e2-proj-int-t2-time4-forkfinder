using ForkFinder.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace ForkFinder.Controllers
{
    public class RestaurantesController : Controller
    {
        private readonly AppDbContext _context;
        public RestaurantesController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var data = _context.Restaurantes.ToList();
            return View(data);
        }

        [AllowAnonymous]
        public async Task<IActionResult> Restaurante(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var restaurante = await _context.Restaurantes
                /*.Include(r => r.Produtos)
                    .Include(r => r.Especialidade)*/
                .FirstOrDefaultAsync(r => r.Id == id);
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
                .FirstOrDefaultAsync(n => n.Id == id);
            if (restaurante == null)
            {
                return NotFound();
            }

            return View(restaurante);
        }

    }
}
using ForkFinder.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace ForkFinder.Controllers
{
    public class MesasController : Controller
    {
        private readonly AppDbContext _context;
        public MesasController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            /*var clientesList = db.Clientes.Include(u => u.Mesas);
            return View(await Clientes.ToListAsync());*/
            var data = await _context.Mesas.ToListAsync();
            return View(data);
        }
    }
}

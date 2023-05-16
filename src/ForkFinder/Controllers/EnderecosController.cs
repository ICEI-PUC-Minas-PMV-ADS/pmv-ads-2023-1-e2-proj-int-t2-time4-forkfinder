using ForkFinder.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace ForkFinder.Controllers
{
    public class EnderecosController : Controller
    {
        private readonly AppDbContext _context;
        public EnderecosController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _context.Enderecos.ToListAsync();
            return View();
        }
    }
}

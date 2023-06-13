using ForkFinder.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace ForkFinder.Controllers
{
    public class EspecialidadesController : Controller
    {
        private readonly AppDbContext _context;
        public EspecialidadesController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var query = _context.Especialidades
                .Include(am => am.Especialidades_Restaurantes).ThenInclude(r => r.Restaurante)
                .Include(am => am.Especialidades_Restaurantes).ThenInclude(r => r.Restaurante).ThenInclude(e => e.Endereco)
                .Include(am => am.Especialidades_Restaurantes).ThenInclude(r => r.Restaurante).ThenInclude(a => a.Avaliacoes)
                .Include(am => am.Especialidades_Restaurantes).ThenInclude(r => r.Restaurante).ThenInclude(m => m.Mesas).ThenInclude(h => h.Horarios)
                .AsQueryable();
            var data = await query.ToListAsync();
            return View(data);
        }



        public async Task<IActionResult> Look(int id)
        {
            var especialidade = await _context.Especialidades
                .Include(am => am.Especialidades_Restaurantes).ThenInclude(r => r.Restaurante)
                .Include(am => am.Especialidades_Restaurantes).ThenInclude(r => r.Restaurante).ThenInclude(e => e.Endereco)
                .Include(am => am.Especialidades_Restaurantes).ThenInclude(r => r.Restaurante).ThenInclude(a => a.Avaliacoes)
                .Include(am => am.Especialidades_Restaurantes).ThenInclude(r => r.Restaurante).ThenInclude(m => m.Mesas).ThenInclude(h => h.Horarios)
                .FirstOrDefaultAsync(n => n.Id == id);

            if (especialidade == null)
            {
                return NotFound();
            }

            return View(especialidade);
        }


    }
}

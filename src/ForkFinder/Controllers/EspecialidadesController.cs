﻿using ForkFinder.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            var data = await _context.Especialidades.ToListAsync();
            return View(data);
        }
    }
}
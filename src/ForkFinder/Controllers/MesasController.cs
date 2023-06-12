using ForkFinder.Data;
using ForkFinder.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace ForkFinder.Controllers
{
    [Authorize(Roles = "Restaurante")]
    public class MesasController : Controller
    {
        private readonly AppDbContext _context;

        public MesasController(AppDbContext context)
        {
            _context = context;
        }

        // GET: /Mesas
        public async Task<IActionResult> Index()
        {
            var restauranteIdClaim = User.FindFirst("RestauranteId")?.Value;

            if (restauranteIdClaim == null)
            {
                // Lidar com o caso em que o ID do restaurante não está presente no usuário logado
                // Por exemplo, redirecionar para uma página de erro ou retornar uma mensagem de erro
                return RedirectToAction("Error", "Home");
            }

            if (!int.TryParse(restauranteIdClaim, out int restauranteId))
            {
                // Lidar com o caso em que o ID do restaurante não é um valor inteiro válido
                // Por exemplo, redirecionar para uma página de erro ou retornar uma mensagem de erro
                return RedirectToAction("Error", "Home");
            }

            var mesas = await _context.Mesas
                .Where(m => m.RestauranteId == restauranteId)
                .ToListAsync();

            var mesaViewModel = new MesaViewModel
            {
                Mesas = mesas
            };

            return View(mesaViewModel);
        }

        // GET: /Mesas/Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // POST: /Mesas/Create
        [HttpPost]
        public async Task<IActionResult> Create(MesaViewModel mesaViewModel)
        {
            if (ModelState.IsValid)
            {
                var restauranteIdClaim = User.FindFirst("RestauranteId")?.Value;
                if (int.TryParse(restauranteIdClaim, out int restauranteId))
                {
                    var restaurante = await _context.Restaurantes.FindAsync(restauranteId);
                    if (restaurante != null)
                    {
                        foreach (var mesa in mesaViewModel.Mesas)
                        {
                            var novaMesa = new Mesa
                            {
                                TamanhoMesa = mesa.TamanhoMesa,
                                QuantidadeMesa = mesa.QuantidadeMesa,
                                Agendada = false,
                                Descricao = "",
                                RestauranteId = restaurante.RestauranteId
                            };

                            _context.Mesas.Add(novaMesa);
                        }

                        await _context.SaveChangesAsync();

                        return RedirectToAction("Index", "Mesas");
                    }
                }
            }

            // Se ocorrer um erro, retorne a view com o modelo inválido para exibir os erros de validação
            return View(mesaViewModel);
        }



        [HttpPost]
        public async Task<IActionResult> Activate(int mesaId)
        {
            var mesa = await _context.Mesas.FindAsync(mesaId);
            if (mesa != null)
            {
                // Lógica para ativar a mesa
                mesa.Agendada = true;
                await _context.SaveChangesAsync();
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Deactivate(int mesaId)
        {
            var mesa = await _context.Mesas.FindAsync(mesaId);
            if (mesa != null)
            {
                // Lógica para desativar a mesa
                mesa.Agendada = false;
                await _context.SaveChangesAsync();
            }
            return RedirectToAction("Index");
        }
    }
}
using ForkFinder.Data;
using ForkFinder.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System;
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
                .Include(h => h.Horarios)
                .Include(r => r.Restaurante).ThenInclude(f => f.Funcionamento)
                .ToListAsync();

            var restaurante = await _context.Restaurantes
                .Include(r => r.Funcionamento)
                .FirstOrDefaultAsync(r => r.RestauranteId == restauranteId);

            if (restaurante != null)
            {
                var mesaViewModel = new MesaViewModel
                {
                    Mesas = mesas,
                    Restaurante = restaurante,
                    Funcionamento = restaurante.Funcionamento
                };

                return View(mesaViewModel);
            }

            return View();
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
                    var restaurante = await _context.Restaurantes
                        .Include(r => r.Funcionamento)
                        .FirstOrDefaultAsync(r => r.RestauranteId == restauranteId);

                    if (restaurante != null)
                    {
                        mesaViewModel.Horarios = GetHorariosByDiaSemana(restaurante.Funcionamento, mesaViewModel.DiaSemana).ToList();

                        for (int i = 0; i < mesaViewModel.QuantidadeMesa; i++)
                        {
                            var novaMesa = new Mesa
                            {
                                TamanhoMesa = mesaViewModel.TamanhoMesa,
                                QuantidadeMesa = mesaViewModel.QuantidadeMesa,
                                Agendada = false,
                                Descricao = "",
                                RestauranteId = restaurante.RestauranteId,
                                Agendas = mesaViewModel.Agendas
                            };

                            // Salvar a nova mesa no banco de dados
                            _context.Mesas.Add(novaMesa);
                            await _context.SaveChangesAsync();

                            // Adicionar os horários à mesa
                            foreach (var horario in mesaViewModel.Horarios)
                            {
                                novaMesa.Horarios.Add(new Horario { Hora = Convert.ToDateTime(horario) });
                            }

                            // Salvar as alterações dos horários no banco de dados
                            await _context.SaveChangesAsync();
                        }

                        return RedirectToAction("Index", "Mesas");
                    }
                }
            }

            // Se ocorrer um erro, retorne a view com o modelo inválido para exibir os erros de validação
            return View(mesaViewModel);
        }



       // Método auxiliar para obter os horários com base no dia da semana
private List<string> GetHorariosByDiaSemana(List<Funcionamento> tabelaFuncionamento, string diaSemana)
{
    var horarios = new List<string>();

    // Procurar o dia da semana na tabela de funcionamento
    var funcionamentoDiaSemana = tabelaFuncionamento.FirstOrDefault(f => f.DiaDaSemana == diaSemana);

    if (funcionamentoDiaSemana != null)
    {
        // Verificar se o horário é "Fechado"
        if (funcionamentoDiaSemana.HorarioInicio == "Fechado" || funcionamentoDiaSemana.HorarioFim == "Fechado")
        {
            horarios.Add("Fechado");
        }
        else
        {
            // Obter horário de início e fim
            TimeSpan horarioInicio;
            TimeSpan horarioFim;

            // Verificar se os horários podem ser convertidos para TimeSpan
            bool parseHorarioInicio = TimeSpan.TryParse(funcionamentoDiaSemana.HorarioInicio, out horarioInicio);
            bool parseHorarioFim = TimeSpan.TryParse(funcionamentoDiaSemana.HorarioFim, out horarioFim);

            if (parseHorarioInicio && parseHorarioFim)
            {
                // Gerar os horários de 10:00 às 00:00 com intervalo de uma hora
                var horarioAtual = horarioInicio;
                while (horarioAtual <= horarioFim)
                {
                    horarios.Add(horarioAtual.ToString("hh\\:mm"));
                    horarioAtual = horarioAtual.Add(TimeSpan.FromHours(1));
                }
            }
            else
            {
                // Lidar com o caso em que os horários não são válidos
                // Por exemplo, retornar uma mensagem de erro ou um valor padrão
                horarios.Add("Horários inválidos");
            }
        }
    }

    return horarios;
}

        [HttpGet]
        public IActionResult GetHorariosByDiaSemana(string diaSemana)
        {
            var restauranteIdClaim = User.FindFirst("RestauranteId")?.Value;
            if (int.TryParse(restauranteIdClaim, out int restauranteId))
            {
                var restaurante = _context.Restaurantes
                    .Include(r => r.Funcionamento)
                    .FirstOrDefault(r => r.RestauranteId == restauranteId);

                if (restaurante != null)
                {
                    var horarios = GetHorariosByDiaSemana(restaurante.Funcionamento, diaSemana);
                    return Json(horarios);
                }
            }

            return Json(null);
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
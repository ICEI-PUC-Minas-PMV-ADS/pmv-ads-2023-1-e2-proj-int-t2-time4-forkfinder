using ForkFinder.Data;
using ForkFinder.Models;
using ForkFinder.ViewModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ForkFinder.Controllers
{
    public class AgendaController : Controller
    {
        private readonly AppDbContext _context;

        public AgendaController(AppDbContext context)
        {
            _context = context;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index(int restauranteId)
        {
            var restaurante = await _context.Restaurantes
                .Include(r => r.Mesas)
                .FirstOrDefaultAsync(r => r.RestauranteId == restauranteId);

            if (restaurante == null)
            {
                return NotFound();
            }

            var agendaViewModel = new AgendaViewModel
            {
                Restaurante = restaurante,
                DataMesas = GetAgendaDates(),
                Horarios = GetAgendaHorarios(),
                Mesas = restaurante.Mesas
            };

            return View(agendaViewModel);
        }
       
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Reservar(int mesaId, int restauranteId, DateTime data, string horario)
        {
            var restaurante = await _context.Restaurantes
                .Include(r => r.Mesas)
                .FirstOrDefaultAsync(r => r.RestauranteId == restauranteId);

            if (restaurante == null)
            {
                return NotFound();
            }

            var mesa = restaurante.Mesas.FirstOrDefault(m => m.Id == mesaId);

            if (mesa == null)
            {
                return NotFound();
            }

            var agenda = new Agenda
            {
                Data = data,
                MesaId = mesaId
            };

            _context.Agendas.Add(agenda);

            var horarioAgenda = new Horario
            {
                Hora = horario,
                Agenda = agenda
            };

            _context.Horarios.Add(horarioAgenda);

            await _context.SaveChangesAsync();

            return RedirectToAction("Index", new { restauranteId });
        }

        private List<DataMesa> GetAgendaDates()
        {
            var datas = new List<DataMesa>();
            var currentDate = DateTime.Now.Date;

            for (int i = 0; i < 5; i++)
            {
                var dataMesa = new DataMesa
                {
                    Data = currentDate.AddDays(i)
                };

                datas.Add(dataMesa);
            }

            return datas;
        }


        private List<Horario> GetAgendaHorarios()
        {
            // Lógica para obter os horários da agenda
            // Pode ser uma lista pré-definida, com intervalos fixos, etc.
            // Aqui, como exemplo, retornamos uma lista de horários por hora

            var horarios = new List<Horario>();
            var startTime = new TimeSpan(8, 0, 0);
            var endTime = new TimeSpan(18, 0, 0);

            while (startTime < endTime)
            {
                horarios.Add(startTime.ToString(@"hh\:mm"));
                startTime = startTime.Add(new TimeSpan(1, 0, 0));
            }

            return horarios;
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using ForkFinder.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using ForkFinder.Data;
using ForkFinder.ViewModels;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;

namespace ForkFinder.Controllers
{
    public class ReservasController : Controller
    {
        private readonly AppDbContext _context;

        public ReservasController(AppDbContext context)
        {
            _context = context;
        }
      
        public async Task<IActionResult> Index(bool reservaAprovada = false)
        {
            var restauranteIdClaim = User.FindFirst("RestauranteId")?.Value;
            if (int.TryParse(restauranteIdClaim, out int restauranteId))
            {
                var restaurante = await _context.Restaurantes.FindAsync(restauranteId);
                if (restaurante != null && restaurante.Papel == Papel.Restaurante)
                {
                                        // Buscar as mesas do restaurante com suas reservas e relacionamento com Cliente
                    var mesas = _context.Mesas.Where(m => m.RestauranteId == restaurante.RestauranteId)
                        .Include(m => m.Reservas).ThenInclude(r => r.Cliente)
                        .Include(m => m.Reservas).ThenInclude(r => r.Agenda)
                        .Select(m => new MesaComReservas
                        {
                            Mesa = m,
                            Reservas = _context.Reservas.Where(r => r.MesaId == m.Id).ToList()
                        })
                        .ToList();

                    ViewBag.ReservaAprovada = reservaAprovada;

                    return View(mesas);
                }
                return RedirectToAction("Index");
            }
            return RedirectToAction("Login", "Restaurantes");
        }

        public IActionResult AprovarReserva(int id)
        {
            Reserva reserva = _context.Reservas.Find(id);
            if (reserva != null)
            {
                reserva.Situacao = (Situacao)1;
                _context.SaveChanges();
            }
            return RedirectToAction("Index", new { reservaAprovada = true });
        }

        public ActionResult RecusarReserva(int id)
        {
            Reserva reserva = _context.Reservas.Find(id);

            if (reserva != null)
            {
                reserva.Situacao = (Situacao)2;
                // Atualize a coluna "Agendado" para "false" na tabela "Horario"
                var horario = _context.Horarios.FirstOrDefault(h => h.Id == reserva.HorarioId);
                if (horario != null)
                {
                    horario.Agendado = false;
                    _context.SaveChanges();
                }
            }

            return RedirectToAction("Index");
        }

        public ActionResult RegistroReservas()
        {
            var reservas = _context.Reservas
                .Include(r => r.Agenda)
                .Include(r => r.Cliente)
                .OrderByDescending(r => r.DataHoraCriacao)
                .ToList();

            var reservasViewModel = reservas.Select(r => new ReservaViewModel
            {
                Agenda = r.Agenda,
                Cliente = r.Cliente,
                Descricao = r.Descricao,
                Situacao = r.Situacao,
                DataCriacao = r.DataHoraCriacao
            }).ToList();

            return View(reservasViewModel);
        }

    }
}

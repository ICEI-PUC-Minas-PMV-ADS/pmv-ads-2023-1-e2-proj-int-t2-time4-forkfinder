using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ForkFinder.Models;

namespace ForkFinder.ViewModels
{
    public class AgendaViewModel
    {
        public Restaurante Restaurante { get; set; }
        public List<DateTime> DataMesas { get; set; }
        public List<string> Horarios { get; set; }
        public List<Mesa> Mesas { get; set; }

        // Propriedade para rastrear o horário da agenda selecionado
        public string SelectedAgenda { get; set; }
    }
}

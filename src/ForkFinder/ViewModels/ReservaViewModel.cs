using ForkFinder.Models;
using System;

namespace ForkFinder.ViewModels
{
    public class ReservaViewModel
    {
        public Agenda Agenda { get; set; }
        public Cliente Cliente { get; set; }
        public string Descricao { get; set; }
        public Situacao Situacao { get; set; }
        public DateTime DataCriacao { get; set; }
    }
}

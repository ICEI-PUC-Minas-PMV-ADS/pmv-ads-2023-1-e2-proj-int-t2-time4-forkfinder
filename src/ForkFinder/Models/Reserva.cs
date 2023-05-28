using eTickets.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ForkFinder.Models
{
    public class Reserva
    {
       [Key]
        public int Id { get; set; }
        [ScaffoldColumn(false)]
        [Display (Name = "Data da Criação da Reserva")]
        public DateTime DataHoraCriacao { get; set; }
        [Display(Name = "Data da Reserva")]
        public DateTime DataHoraReserva { get; set; }
        [Display(Name = "Complemento para reserva")]
        public string Descricao { get; set; }
        [Display(Name = "Situação da Reserva")]
        public bool Situacao { get; set; }

        /* Relationships*/
        public int ClienteId { get; set; }
        [ForeignKey("ClienteId")]
        public Cliente Cliente { get; set; }

       
       public int MesaId { get; set; }
        [ForeignKey("MesaId")]
        public Mesa Mesa { get; set; }
        /*public string UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        public ApplicationUser User { get; set; }*/
    }
}

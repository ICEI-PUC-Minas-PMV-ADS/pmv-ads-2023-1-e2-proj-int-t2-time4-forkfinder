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
        public Situacao Situacao { get; set; }

        /* Relationships*/
        public int ClienteId { get; set; }
        [ForeignKey("ClienteId")]
        public Cliente Cliente { get; set; }       
        public int MesaId { get; set; }
        [ForeignKey("MesaId")]
        public Mesa Mesa { get; set; }
        
        /*New*/
        public int RestauranteId { get; set; }
        [ForeignKey("RestauranteId")]
        public Restaurante Restaurante { get; set; }
        public int HorarioId { get; set; }
        [ForeignKey("HorarioId")]
        public Horario Horario { get; set; }
        public int AgendaId { get; set; }
        [ForeignKey("AgendaId")]
        public Agenda Agenda { get; set; }
        public int EspecialidadeId { get; set; }
        [ForeignKey("EspecialidadeId")]
        public Especialidade Especialidade { get; set; }
    }
    public enum Situacao
    {
        Pendente = 0,
        Aprovada = 1,
        Recusada = 2
    }
}

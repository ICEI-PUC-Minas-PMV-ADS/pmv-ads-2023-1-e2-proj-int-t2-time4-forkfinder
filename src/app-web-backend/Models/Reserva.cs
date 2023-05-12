using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace fork_finder.Models
{
    public class Reserva
    {
       /* [Key]
        public Guid Id { get; set; }*/
        [ScaffoldColumn(false)]
        public DateTime DataHoraCriacao { get; set; }
        public DateTime DataHoraReserva { get; set; }
        public string Descricao { get; set; }
        public bool Situacao { get; set; }

        /* Relacionamento Restaurante */
        public Guid MesaId { get; set; }
        public Mesa Mesa { get; set; }

        /* Relacionamento Cliente */
        [Key]
        public Guid ClienteId { get; set; }
        public Cliente Cliente { get; set; }

    }
}

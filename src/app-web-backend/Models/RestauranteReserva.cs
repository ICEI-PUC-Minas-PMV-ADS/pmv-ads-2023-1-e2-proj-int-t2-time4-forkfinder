using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace fork_finder.Models
{
    public class RestauranteReserva
    {
        [Key]
        public Guid RestauranteReservaId { get; set; }
        [ScaffoldColumn(false)]
        public DateTime DataHoraCriacao { get; set; }
        public DateTime DataHoraReserva { get; set; }
        public string Descricao { get; set; }
        public bool Situacao { get; set; }

        /* Relacionamento Restaurante */
        public Guid RestauranteId { get; set; }
        [ForeignKey("RestauranteId")]
        public Restaurante Restaurante { get; set; }

        /* Relacionamento Cliente */
        public Guid ClienteId { get; set; }
        [ForeignKey("ClienteId")]
        public Cliente Cliente { get; set; }

        public ICollection<RestauranteMesa> RestauranteMesas { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace fork_finder.Models
{
    [Table("Avaliacoes")]
    public class Avaliacao
    {
        /* [Key]
         public Guid AvaliacaoId { get; set; }*/

        public DateTime DataCriacao { get; set; }
        public int Estrela { get; set; }


        /* Relacionamento Restaurante */
        [Key]
        public Guid ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        /* Relacionamento Cliente */
        public Guid RestauranteId { get; set; }        
        public Restaurante Restaurante { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace fork_finder.Models
{
    [Table("ClienteAvaliacoes")]
    public class ClienteAvaliacao
    {
        [Key]
        public Guid ClienteAvaliacaoId { get; set; }

        public DateTime DataCriacao { get; set; }
        public int Estrela { get; set; }


        /* Relacionamento Restaurante */
        public virtual Restaurante Restaurante { get; set; }

        /* Relacionamento Cliente */

        public Guid ClienteId { get; set; }
        [ForeignKey("ClienteId")]
        public Cliente Cliente { get; set; }
    }
}

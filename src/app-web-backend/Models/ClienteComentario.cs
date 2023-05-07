using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace fork_finder.Models
{
    public class ClienteComentario
    {
        [Key]
        public Guid ClienteComentarioId { get; set; }
        public DateTime DataCriacao { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        public string ConteudoComentario { get; set; }

        /* Relacionamento Restaurante */
        public ICollection<Restaurante> Restaurantes { get; set; }

        /* Relacionamento Cliente */
        public Guid ClienteId { get; set; }
        [ForeignKey("ClienteId")]
        public Cliente Cliente { get; set; }
    }
}


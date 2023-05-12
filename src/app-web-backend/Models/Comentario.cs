using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace fork_finder.Models
{
    public class Comentario
    {
        /*[Key]
        public Guid ComentarioId { get; set; }*/
        public DateTime DataCriacao { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        public string ConteudoComentario { get; set; }

        /* Relacionamento Restaurante */
        public Guid RestauranteId { get; set; }
        public Restaurante Restaurante { get; set; }

        /* Relacionamento Cliente */
        [Key]
        public Guid ClienteId { get; set; }
        public Cliente Cliente { get; set; }
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ForkFinder.Models
{
    public class Comentario
    {
        [Key]
        public int Id { get; set; }
        public DateTime DataCriacao { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        public string ConteudoComentario { get; set; }

        /* Relacionamento Restaurante */
        public int RestauranteId { get; set; }
        [ForeignKey("RestauranteId")]
        public Restaurante Restaurante { get; set; }

        /* Relacionamento Cliente */
        public int ClienteId { get; set; }
        [ForeignKey("ClienteId")]
        public Cliente Cliente { get; set; }
    }
}


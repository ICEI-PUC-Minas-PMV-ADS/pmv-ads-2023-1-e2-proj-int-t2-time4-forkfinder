using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace fork_finder.Models
{
    public class Foto
    {
        [Key]
        public Guid RestauranteId { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        public string FotosRestaurante { get; set; }

        /* Relacionamento Restaurante */
        public Restaurante Restaurante { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace fork_finder.Models
{
    public class RestauranteFoto
    {
        [Key]
        public Guid RestauranteFotoId { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        public string FotosRestaurante { get; set; }

        /* Relacionamento Restaurante */
        public ICollection<Restaurante> Restaurantes { get; set; }
    }
}

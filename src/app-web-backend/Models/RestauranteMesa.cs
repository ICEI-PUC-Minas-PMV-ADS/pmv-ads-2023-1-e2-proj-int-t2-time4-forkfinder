using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace fork_finder.Models
{
    public class RestauranteMesa
    {
        [Key]
        public Guid RestauranteMesaId { get; set; }


        [Display(Name = "Quantidade de Mesa")]
        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        public int QuantidadeMesa { get; set; }

        [Display(Name = "Capacidade da Mesa")]
        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        public int TamanhoMesa { get; set; }


        /* Relacionamento Restaurante */
        public Guid RestauranteReservaId { get; set; }
        [ForeignKey("RestauranteReservaId")]
        public RestauranteReserva RestauranteReserva { get; set; }
    }
}

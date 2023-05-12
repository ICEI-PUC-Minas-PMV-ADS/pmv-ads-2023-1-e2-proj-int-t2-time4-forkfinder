using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace fork_finder.Models
{
    public class Mesa
    {
        [Key]
        public Guid Id { get; set; }


        [Display(Name = "Quantidade de Mesa")]
        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        public int QuantidadeMesa { get; set; }

        [Display(Name = "Capacidade da Mesa")]
        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        public int TamanhoMesa { get; set; }


        /* Relacionamento Restaurante */
        public Guid RestauranteId { get; set; }
        public Restaurante Restaurante { get; set; }

        public ICollection<Reserva> Reservas { get; set; }
    }
}
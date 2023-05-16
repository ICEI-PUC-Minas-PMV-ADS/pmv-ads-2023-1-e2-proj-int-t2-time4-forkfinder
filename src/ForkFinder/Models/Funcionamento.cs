using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ForkFinder.Models
{
    [Table("Funcionamentos")]
    public class Funcionamento
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Horário de Início")]
        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        public DateTime HorarioInicio { get; set; }

        [Display(Name = "Horário de Fim")]
        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        public DateTime HorarioFim { get; set; }

        [Display(Name = "Dia da Semana")]
        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        public DateTime DiaDaSemana { get; set; }

        /* Relacionamento Restaurante */        
        public int RestauranteId { get; set; }
        [ForeignKey("RestauranteId")]
        public Restaurante Restaurante { get; set; }
    }
}

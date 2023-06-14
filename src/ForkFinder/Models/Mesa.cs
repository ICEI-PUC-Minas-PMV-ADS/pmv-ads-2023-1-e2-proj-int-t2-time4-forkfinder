using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ForkFinder.Models
{
    public class Mesa
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Quantidade de Mesa")]
        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        public int QuantidadeMesa { get; set; }

        [Display(Name = "Capacidade da Mesa")]
        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        public int TamanhoMesa { get; set; }

        [Display(Name = "Descrição da Mesa")]
        public string Descricao { get; set; }

        /* Relacionamento Restaurante */
        public int RestauranteId { get; set; }
        [ForeignKey("RestauranteId")]
        public Restaurante Restaurante { get; set; }

        public List<Reserva> Reservas { get; set; }

        public List<Agenda> Agendas { get; set; }
        public List<Horario> Horarios { get; set; }
        public bool Agendada { get; set; }
    }
}

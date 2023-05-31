using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ForkFinder.Models
{
    public class Horario
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Horário")]
        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        public string Hora { get; set; }

        // Relacionamento com Agenda
        public int AgendaId { get; set; }
        [ForeignKey("AgendaId")]
        public Agenda Agenda { get; set; }
    }
}
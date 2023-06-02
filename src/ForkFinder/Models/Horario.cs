using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ForkFinder.Models
{
    [Table("Horarios")]
    public class Horario
    {        
        [Key]
        public int Id { get; set; }

        [Display(Name = "Horário")]
        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        public string Hora { get; set; }

        // Relacionamento com Agenda
        public int MesaId { get; set; }
        [ForeignKey("MesaId")]
        public Mesa Mesas { get; set; }
    }
}

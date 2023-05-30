using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ForkFinder.Models
{
    public class Agenda
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Data")]
        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        public DateTime Data { get; set; }
        [Display(Name = "Data")]
        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        public string Horario { get; set; }
        /* Relacionamento */
        public int MesaId { get; set; }
        [ForeignKey("MesaId")]
        public Mesa Mesa { get; set; }
    }
}

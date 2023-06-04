using System;
using System.Collections.Generic;
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

        // Relacionamento com Mesa
        public int MesaId { get; set; }
        [ForeignKey("MesaId")]
        public Mesa Mesa { get; set; }

        public List<Horario> Horarios { get; set; }
    }
}

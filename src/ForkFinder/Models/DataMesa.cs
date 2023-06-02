using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ForkFinder.Models
{
    public class DataMesa
    {
        [Key]
        public int Id { get; set; }
        
        public DateTime DataMesas { get; set; }

        // Relacionamento com Agenda
        public int AgendaId { get; set; }
        [ForeignKey("AgendaId")]
        public Agenda Agenda { get; set; }
    }
}

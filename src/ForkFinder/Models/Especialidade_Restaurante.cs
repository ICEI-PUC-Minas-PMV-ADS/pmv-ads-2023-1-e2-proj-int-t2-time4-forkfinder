using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ForkFinder.Models
{
    [Table("Especialidades_Restaurantes")]
    public class Especialidade_Restaurante
    {       
        public int RestauranteId { get; set; }
        public Restaurante Restaurante { get; set; }
        public int EspecialidadeId { get; set; }
        public Especialidade Especialidade { get; set; }
      
    }
}

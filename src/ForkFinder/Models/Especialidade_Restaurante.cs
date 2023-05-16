using System;

namespace ForkFinder.Models
{
    public class Especialidade_Restaurante
    {
        public int RestauranteId { get; set; }
        public Restaurante Restaurante { get; set; }
        public int EspecialidadeId { get; set; }
        public Especialidade Especialidade { get; set; } 
    }
}

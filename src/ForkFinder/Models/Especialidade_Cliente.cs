using System;

namespace ForkFinder.Models
{
    public class Especialidade_Cliente
    {
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public int EspecialidadeId { get; set; }
        public Especialidade Especialidade { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ForkFinder.Models
{
    [Table("Especialidades")]
    public class Especialidade
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        public string NomeEspecialidade { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        public string ImagemUpload { get; set; }
        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }

        /* Relacionamento Restaurante */
        public List<Especialidade_Restaurante> Especialidades_Restaurantes { get; set; }

        /* Relacionamento Cliente */
        public List<Especialidade_Cliente> Especialidades_Clientes { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace fork_finder.Models
{
    [Table("Especialidades")]
    public class Especialidade
    {
        [Key]
        public Guid EspecialidadeId { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        public string NomeEspecialidade { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        public string ImagemUpload { get; set; }
        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }

        /* Relacionamento Restaurante */
        public ICollection<Restaurante> Restaurantes { get; set; }

        /* Relacionamento Cliente */
        public Cliente Cliente { get; set; }
    }
}

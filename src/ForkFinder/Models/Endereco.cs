using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ForkFinder.Models
{
    [Table("Enderecos")]
    public class Endereco
    {

        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        [StringLength(50, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres!", MinimumLength = 1)]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        [StringLength(9, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres!", MinimumLength = 1)]
        public string Numero { get; set; }
        public string Complemento { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        [StringLength(9, ErrorMessage = "O campo {0} precisa ter {1} caracteres!", MinimumLength = 1)]
        public string CEP { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        public string Estado { get; set; }


        /* Relacionamento Restaurante */
        
        public int RestauranteId { get; set; }
        [ForeignKey("RestauranteId")]
        public Restaurante Restaurante { get; set; }
    }
}

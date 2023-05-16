using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ForkFinder.Models
{
    public class Produto
    {
        [Key]
        public int Id { get; set; }


        [Display(Name = "Nome do Prato")]
        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres!", MinimumLength = 2)]
        public string NomeProduto { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        [StringLength(1000, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres!", MinimumLength = 2)]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres!", MinimumLength = 2)]
        public string Imagem { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        [Display(Name = "Preço")]
        public decimal Preco { get; set; }

         /* Relationships */

        public int CategoriaId { get; set; }
        [ForeignKey("CategoriaId")]
        public Categoria Categoria { get; set; }

     /*   public Guid RestauranteId { get; set; }
        [ForeignKey("RestauranteId")]
        public Restaurante Restaurante { get; set; }*/
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace fork_finder.Models
{
    public class Categoria
    {
       [Key]
        public Guid Id { get; set; }


        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        public string Nome { get; set; }
        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        public string Descricao { get; set; }
        public string Imagem { get; set; }

        /* Relacionamento de produto */
        public ICollection<Produto> Produtos { get; set; }
        public Guid RestauranteId { get; set; }
        public Restaurante Restaurante { get; set; }

    }
}

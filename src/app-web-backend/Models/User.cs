using System;
using System.ComponentModel.DataAnnotations;

namespace fork_finder.Models
{
    public class User : Entity
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres!", MinimumLength = 2)]
        [Display(Name = "Nome Completo")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        public string Senha { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório!")]

        [ScaffoldColumn(false)]
        public DateTime CreateDate { get; set; }

        [Required]
        public Regra Regra { get; set; }

    }
    public enum Regra
    {
        Cliente = 0,
        Restaurante = 1,
        Admin = 2
    }

}

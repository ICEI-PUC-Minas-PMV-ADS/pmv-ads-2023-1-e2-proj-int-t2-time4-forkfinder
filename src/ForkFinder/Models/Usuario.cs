using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;

namespace ForkFinder.Models
{
    public abstract class Usuario
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres!", MinimumLength = 2)]
        [Display(Name = "Nome Completo")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }
        /*[Required(ErrorMessage = "O campo {0} é obrigatório!")]*/
        /* public int Telefone { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        public string Idioma { get; set; }
        [ScaffoldColumn(false)]
        public DateTime CreateDate { get; set; }
        */
        [Required]
        public Papel Papel { get; set; }

    }
    public enum Papel
    {
        Cliente = 0,
        Restaurante = 1,
        Admin = 2
    }

}

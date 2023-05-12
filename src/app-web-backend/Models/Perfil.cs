using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace fork_finder.Models
{
    public class Perfil
    {
        [Key]
        public Guid ClienteId { get; set; }


        [Display(Name = "Foto de perfil")]
        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        public string FotoCliente { get; set; }


        /* Relacionamento */
        public Cliente Cliente { get; set; }

        public ICollection<Especialidade> Especialidades { get; set; }

    }
}

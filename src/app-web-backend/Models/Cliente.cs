using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace fork_finder.Models
{
    public class Cliente : Usuario
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        public string CPF { get; set; }

        /* Relacionamentos */
        public Perfil Perfil { get; set; }
        public ICollection<Reserva> Reservas { get; set; }
        public ICollection<Avaliacao> Avaliacoes { get; set; }
        public ICollection<Comentario> Comentarios { get; set; }

    }

}

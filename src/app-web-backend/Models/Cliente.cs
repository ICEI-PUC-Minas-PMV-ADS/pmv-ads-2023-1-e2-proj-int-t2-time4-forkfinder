using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace fork_finder.Models
{
    public class Cliente : Usuario
    {
        [Key]
        public Guid ClienteId { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        public string CPF { get; set; }

        /* Relacionamentos */
        public ClientePerfil Perfil { get; set; }
        public ICollection<RestauranteReserva> RestauranteReservas { get; set; }
      
        public ICollection<ClienteAvaliacao> ClienteAvaliacoes { get; set; }
        public ICollection<ClienteComentario> ClienteComentarios { get; set; }

    }

}

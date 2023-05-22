using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ForkFinder.Models
{
    public class Cliente : Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        public string CPF { get; set; }
        public string Foto { get; set; }
        // Relationships
        public List<Reserva> Reservas { get; set; }
        public List<Especialidade_Cliente> Especialidades_Clientes { get; set; }
        public List<Avaliacao> Avaliacoes { get; set; }
        public List<Comentario> Comentarios { get; set; }

    }

}

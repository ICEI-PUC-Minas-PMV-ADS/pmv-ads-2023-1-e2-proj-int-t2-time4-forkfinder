using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace fork_finder.Models
{
    public class Restaurante : Usuario
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        public string CNPJ { get; set; }

        [Display(Name = "Link logo perfil")]
        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        public string FotoPerfil { get; set; }

        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "O campo {0} é obrigatório!")]

        public string DescricaoRestaurante { get; set; }
        public ICollection<Especialidade> Especialidades { get; set; }       
        public ICollection<Categoria> Categorias { get; set; }
        public ICollection<Comentario> Comentarios { get; set; }
        public Funcionamento Funcionamento { get; set; }
        public Endereco Endereco { get; set; }
        public ICollection<Foto> Fotos { get; set; }
        public ICollection<Mesa> Mesas { get; set; }
        public ICollection<Avaliacao> Avaliacoes { get; set; }        
        public ICollection<Reserva> Reservas { get; set; }
        public ICollection<Cliente> Clientes { get; set; }
    }
}
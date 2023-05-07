using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace fork_finder.Models
{
    public class Restaurante : Usuario
    {
        [Key]
        public Guid RestauranteId { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        public string CNPJ { get; set; }

        [Display(Name = "Link logo perfil")]
        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        public string FotoPerfil { get; set; }

        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        public string DescricaoRestaurante { get; set; }

        public Guid EspecialidadeId { get; set; }
        [ForeignKey("EspecialidadeId")]
        public Especialidade Especialidade { get; set; }
        /*public Guid ProdutoCategoriaId { get; set; }
        [ForeignKey("ProdutoCategoriaId")]
        public ProdutoCategoria ProdutoCategoria { get; set; }*/
        public virtual ClienteComentario ClienteComentario { get; set; }
        public ICollection<Produto> Produtos { get; set; }
        public Endereco Endereco { get; set; }
        public ICollection<RestauranteFoto> RestauranteFotos { get; set; }
        public ICollection<RestauranteMesa> RestauranteMesas { get; set; }
        public ICollection<ClienteAvaliacao> ClienteAvaliacoes { get; set; }
        public RestauranteFuncionamento Funcionamento { get; set; }
        public ICollection<RestauranteReserva> RestauranteReservas { get; set; }
        public ICollection<Cliente> Clientes { get; set; }
    }
}
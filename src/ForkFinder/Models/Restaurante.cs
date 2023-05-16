using ForkFinder.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ForkFinder.Models
{
    public class Restaurante : Usuario, IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        public string CNPJ { get; set; }

        [Display(Name = "Foto Perfil")]
        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        public string FotoPerfil { get; set; }

        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "O campo {0} é obrigatório!")]

        public string DescricaoRestaurante { get; set; }

        //Relationships
        public List<Especialidade_Restaurante> Especialidades_Restaurantes { get; set; }
        public List<Mesa> Mesas { get; set; }

        public List<Categoria> Categorias { get; set; }
        public List<Comentario> Comentarios { get; set; }
        public Funcionamento Funcionamento { get; set; }
        public Endereco Endereco { get; set; }
        public List<Foto> Fotos { get; set; }
        public List<Avaliacao> Avaliacoes { get; set; }
    }
}
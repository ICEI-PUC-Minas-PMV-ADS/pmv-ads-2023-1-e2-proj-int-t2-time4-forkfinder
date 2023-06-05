using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ForkFinder.Models
{
    [Table("Restaurantes")]
    public class Restaurante : Usuario
    {
        [Key]
        public int RestauranteId { get; set; }

        //[Required(ErrorMessage = "O campo {0} é obrigatório!")]
        public string CNPJ { get; set; }

        [Display(Name = "Foto Perfil")]
        public byte[] FotoPerfil { get; set; }


        [Display(Name = "Descrição")]
        //[Required(ErrorMessage = "O campo {0} é obrigatório!")]
        public string DescricaoRestaurante { get; set; }
        public bool Acessibilidade { get; set; }
        public float Avaliacao { get; set; }

        //Relationships   
        public List<Especialidade_Restaurante> Especialidades_Restaurantes { get; set; }
        public List<Agenda> Agendas { get; set; }
        public virtual List<Mesa> Mesas { get; set; }
        public virtual List<Reserva> Reservas { get; set; }
        public List<Categoria> Categorias { get; set; }
        public List<Comentario> Comentarios { get; set; }
        public Funcionamento Funcionamento { get; set; }
        public Endereco Endereco { get; set; }
        public List<Foto> Fotos { get; set; }
        public List<Avaliacao> Avaliacoes { get; set; }
    }
}
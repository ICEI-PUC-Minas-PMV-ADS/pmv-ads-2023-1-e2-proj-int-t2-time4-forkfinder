using System.ComponentModel.DataAnnotations;

namespace ForkFinder.ViewModels
{
    public class AvaliacaoViewModel
    {
        [Key] // Adicione esta anotação para indicar que é uma chave primária
        public int AvaliacaoId { get; set; }
        public int RestauranteId { get; set; }
        public string Comentario { get; set; }
        public int Pontuacao { get; set; }
        // Outras propriedades relacionadas à avaliação, se necessário
    }
}

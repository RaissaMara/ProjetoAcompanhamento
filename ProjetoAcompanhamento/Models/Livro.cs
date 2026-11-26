// Biblioteca para restrições de integridade dos atributos como chave primaria
using System.ComponentModel.DataAnnotations;

namespace ProjetoAcompanhamento.Models
{
    public class Livro
    {
        // Id já identificada automaticamente como chave primaria

        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Titulo { get; set; } = string.Empty;

        [Required]
        [MaxLength(100)]
        public string Autor { get; set; } = string.Empty;

        public int AnoPublicacao { get; set; }

        public int CategoriaId { get; set; } // Chave estrangeira para a tabela Categoria
        public Categoria? Categoria { get; set; } // Propriedade de navegação para a categoria

    }
}

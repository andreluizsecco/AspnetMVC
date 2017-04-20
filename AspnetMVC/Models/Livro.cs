using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AspnetMVC.Models
{
    public class Livro
    {
        [Required(ErrorMessage = "O Código é obrigatório!")]
        public int ID { get; set; }
        [Required(ErrorMessage = "O Título é obrigatório!")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "O Autor é obrigatório!")]
        public string Autor { get; set; }
        [Required(ErrorMessage = "O Ano de publicação é obrigatório!")]
        [RegularExpression(@"[0-9]{4}", ErrorMessage = "O Ano deve possuir 4 números!")]
        public int AnoPublicacao { get; set; }

        public List<Livro> GetLivros()
        {
            return new List<Livro>
            {
                new Livro
                {
                    ID = 1,
                    Titulo = "Domain-Driven Design: Tackling Complexity in the Heart of Software",
                    Autor = "Eric Evans",
                    AnoPublicacao = 2003
                },
                new Livro
                {
                    ID = 2,
                    Titulo = "Agile Principles, Patterns, and Practices in C#",
                    Autor = "Robert C. Martin",
                    AnoPublicacao = 2006
                },
                new Livro
                {
                    ID = 3,
                    Titulo = "Clean Code: A Handbook of Agile Software Craftsmanship",
                    Autor = "Robert C. Martin",
                    AnoPublicacao = 2008
                }
            };
        }
    }
}
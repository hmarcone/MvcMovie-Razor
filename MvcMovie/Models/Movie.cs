using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required(ErrorMessage = "O campo Release Date é obrigatório e o mínimo de caracteres é 3.")]
        public string Title { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date, ErrorMessage = "O campo Data de lançamento tem que ter uma data válida.")]
        public DateTime ReleaseDate { get; set; }

        [Range(1, 100)]
        [DataType(DataType.Currency, ErrorMessage = "O campo Preço deve ser um número.")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        [Required(ErrorMessage = "O campo Gênero é obrigatório.")]
        [StringLength(30)]
        public string Genre { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$", ErrorMessage = "O campo Rating não é válido.")]
        [StringLength(5)]
        [Required(ErrorMessage = "O campo Rating é obrigatório.")]
        public string Rating { get; set; }
    }
}

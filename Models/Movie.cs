using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MovieCloud.Models
{
    public class Movie
    {
        public int Id { get; set; } //integer is autoincremeneted so u dont need data anotation
        [Required, MaxLength(250)]
        public string Title { get; set; } // u have to write required over strings as its default is null
        public int Year { get; set; }
        public double Rate { get; set; }
        [Required, MaxLength(2500)]
        public string Story { get; set; }
        [Required]
        public byte[] Poster { get; set; }
        public byte GenreId { get; set; } // navigation property
        public Genre Genre { get; set; }
    }
}

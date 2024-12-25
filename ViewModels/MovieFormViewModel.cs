using MovieCloud.Models;
using System.ComponentModel.DataAnnotations;

namespace MovieCloud.ViewModels
{
    public class MovieFormViewModel
    {
        public int Id { get; set; }

        [Required, StringLength(250)]
        public string Title { get; set; } // u have to write required over strings as its default is null
        public int Year { get; set; }
        [Range(1, 10)]
        public double Rate { get; set; }
        [Required, StringLength(2500)]
        public string Story { get; set; }
        [Display(Name = "Select Poster ...")]
        public IFormFile? Poster { get; set; }
        [Display(Name = "Genre")]
        public byte GenreId { get; set; } // navigation property
        public IEnumerable<Genre>? Genres { get; set; }
        public string? PosterBase64 { get; set; }

        public IEnumerable<Review>? Reviews { get; set; }


    }

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieCloud.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string Country { get; set; }
        public string Comment { get; set; }
        [Range(1, 10)]
        public double Rate { get; set; }
        public int MovieId { get; set; }
        public Movie? Movie { get; set; }
    }
}

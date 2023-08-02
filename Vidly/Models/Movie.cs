using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Genre { get; set; }
        [Required]
        public string ReleaseDate { get; set; }
        [Required]
        public string DateAdded { get; set; }
        [Required]
        public string NumerInStock { get; set; }

    }


}
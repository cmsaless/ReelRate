using System.ComponentModel.DataAnnotations;

namespace MVC.Models
{
    public class Movie : BaseEntity
    {
        [Required, Display(Name = "Movie Database ID")]
        public int TMDB_ID { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        [Display(Name = "Year of Release")]
        public string Year { get; set; }
        public string Poster { get; set; }

    }
}

using System.ComponentModel.DataAnnotations;

namespace MVC.Models
{
    public class Movie : BaseEntity
    {
        [Display(Name = "Movie Database ID")]
        public int TMDB_ID { get; set; }
        public string Title { get; set; }
        [Display(Name = "Year of Release")]
        public string Year { get; set; }
        public string Poster { get; set; }
    }
}

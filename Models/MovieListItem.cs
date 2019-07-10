using System.ComponentModel.DataAnnotations;

namespace MVC.Models
{
    public class MovieListItem : BaseEntity
    {
        [Required]
        public string MovieID { get; set; }
        [Required]
        public string ListID { get; set; }
        [Required]
        public int Rank { get; set; }

        public MovieListItem(string ListID, string MovieID)
        {
            this.ListID = ListID;
            this.MovieID = MovieID;
            Rank = 0;
        }
    }
}

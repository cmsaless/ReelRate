namespace MVC.Models
{
    public class MovieListItem : BaseEntity
    {
        public string MovieID { get; set; }
        public string ListID { get; set; }

        public MovieListItem(string ListID, string MovieID)
        {
            this.ListID = ListID;
            this.MovieID = MovieID;
        }
    }
}

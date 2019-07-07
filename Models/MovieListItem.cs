using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

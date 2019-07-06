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

        public MovieListItem(string MovieID, string ListID)
        {
            this.MovieID = MovieID;
            this.ListID = ListID;
        }
    }
}

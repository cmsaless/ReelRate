using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.ViewModels
{
    public class MovieListItemViewModel
    {
        public Movie Movie { get; set; }
        public int Rank { get; set; }

        public MovieListItemViewModel(Movie Movie, int Rank)
        {
            this.Movie = Movie;
            this.Rank = Rank;
        }
    }
}

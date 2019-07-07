using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models
{
    
    public class MovieListViewModel
    {
        public MovieList List { get; set; }
        public List<Movie> Movies { get; set; }

        public MovieListViewModel(MovieList List, List<Movie> Movies)
        {
            this.List = List;
            this.Movies = Movies;
        }
    }
}

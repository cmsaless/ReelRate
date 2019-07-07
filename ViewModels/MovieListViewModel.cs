using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace MVC.Models
{

    public class MovieListViewModel
    {
        public MovieList ModelList { get; set; }
        public List<Movie> Movies { get; set; }

        public MovieListViewModel(MovieList ModelList, List<Movie> Movies)
        {
            this.ModelList = ModelList;
            this.Movies = Movies;
        }
    }
}

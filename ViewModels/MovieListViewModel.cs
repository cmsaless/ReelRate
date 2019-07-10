using System.Collections.Generic;

namespace MVC.Models
{
    public class MovieListViewModel
    {
        public MovieList ModelList { get; set; }
        public List<(int, Movie)> RankedMovies { get; set; }
        public string AddErrorMessage { get; set; }
        public int Size { get; set; }

        public MovieListViewModel(MovieList ModelList, List<(int, Movie)> RankedMovies)
        {
            this.ModelList = ModelList;
            this.RankedMovies = RankedMovies;
            AddErrorMessage = "";
            Size = RankedMovies.Count;
        }

        public MovieListViewModel()
        {
            this.RankedMovies = new List<(int, Movie)>();
            AddErrorMessage = "";
        }
    }
}

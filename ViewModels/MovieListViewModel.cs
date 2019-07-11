using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVC.Models
{
    public class MovieListViewModel
    {
        public MovieList ModelList { get; set; }
        public List<(int, Movie)> RankedMovies { get; set; }
        public string AddMovieErrorMessage { get; set; }

        public MovieListViewModel(MovieList ModelList, List<(int, Movie)> RankedMovies)
        {
            this.ModelList = ModelList;
            this.RankedMovies = RankedMovies;
            AddMovieErrorMessage = "";
        }

        //public MovieListViewModel()
        //{
        //    this.RankedMovies = new List<(int, Movie)>();
        //    AddErrorMessage = "";
        //}
    }
}

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVC.Models
{
    public class MovieListViewModel
    {
        [Required]
        public MovieList ModelList { get; set; }
        [Required]
        public List<(int, Movie)> RankedMovies { get; set; }
        public string AddErrorMessage { get; set; }

        public MovieListViewModel(MovieList ModelList, List<(int, Movie)> RankedMovies)
        {
            this.ModelList = ModelList;
            this.RankedMovies = RankedMovies;
            AddErrorMessage = "";
        }

        //public MovieListViewModel()
        //{
        //    this.RankedMovies = new List<(int, Movie)>();
        //    AddErrorMessage = "";
        //}
    }
}

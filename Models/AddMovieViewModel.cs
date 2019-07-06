using System.Collections.Generic;

namespace MVC.Models
{
    public class AddMovieViewModel
    {
        public MovieList MovieList { get; set; }
        public IEnumerable<Movie> Movies { get; set; }

        public AddMovieViewModel(MovieList movieList, IEnumerable<Movie> movies)
        {
            MovieList = movieList;
            Movies = movies;
        }
        
    }
}

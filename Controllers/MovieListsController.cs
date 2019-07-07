using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MVC.Contracts;
using MVC.Models;

namespace MVC.Controllers
{
    public class MovieListsController : Controller
    {
        private IRepository<MovieList> _context;
        private IRepository<MovieListItem> _contextItems;
        private readonly IRepository<Movie> _movies;

        public MovieListsController(IRepository<MovieList> context, IRepository<MovieListItem> contextItems, IRepository<Movie> movies)
        {
            _context = context;
            _contextItems = contextItems;
            _movies = movies;
        }

        public ActionResult Index()
        {
            List<MovieList> movieLists = _context.Collection().ToList();
            return View(movieLists);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(MovieList movieList)
        {
            _context.Insert(movieList);
            _context.Commit();
            return RedirectToAction("Index");
        }

        public ActionResult Details(string ID)
        {
            MovieList movieList = _context.Find(ID);

            List<string> movieIDs = (from listItem in _contextItems.Collection()
                                  where listItem.ListID == ID
                                  select listItem.MovieID).ToList();

            List<Movie> movies = new List<Movie>();
            foreach(string s in movieIDs)
            {
                movies.Add(_movies.Find(s));
            }

            MovieListViewModel viewModel = new MovieListViewModel(movieList, movies);

            return View(viewModel);
        }

        public ActionResult Add(string ID)
        {
            var movieList = _context.Find(ID);

            AddMovieViewModel viewModel = new AddMovieViewModel(movieList, _movies.Collection());

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Add(string listID, string movieID)
        {
            var movie = _movies.Find(movieID);
            var movieList = _context.Find(listID);

            MovieListItem listItem = new MovieListItem(listID, movieID);
            _contextItems.Insert(listItem);
            _contextItems.Commit();

            movieList.Movies.Add(movie);

            _context.Commit();

            return RedirectToAction("Details", new { ID = listID });
        }

        [HttpPost]
        public ActionResult Remove(string listID, string movieID)
        {

            return RedirectToAction("Details");
        }
    }

}
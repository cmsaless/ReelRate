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
            ViewBag.Me = "You"; // LOOK TO THE VIEWBAG FOR YOUR PROBLEMS
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

        [ActionName("View")]
        public ActionResult ViewList(string ID)
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

            MovieListViewModel viewModel = new MovieListViewModel(movieList, _movies.Collection().ToList());

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Add(string list_id, string movie_id)
        {
            var movie = _movies.Find(movie_id);
            var movieList = _context.Find(list_id);

            MovieListItem listItem = new MovieListItem(list_id, movie_id);
            _contextItems.Insert(listItem);
            _contextItems.Commit();

            movieList.Movies.Add(movie);

            _context.Commit();

            return RedirectToAction("Details", new { ID = list_id });
        }

        [HttpPost]
        public ActionResult Remove(string listID, string movieID)
        {

            return RedirectToAction("Details");
        }
    }

}
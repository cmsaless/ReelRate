using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC.Contracts;
using MVC.Models;
using Newtonsoft.Json;

namespace MVC.Controllers
{
    public class MovieListsController : Controller
    {
        private IRepository<MovieList> _context;
        private IRepository<MovieListItem> _contextItems;
        private readonly IRepository<Movie> _movies;

        private readonly IHttpClientFactory _clientFactory;

        public MovieListsController(IRepository<MovieList> context, IRepository<MovieListItem> contextItems, IRepository<Movie> movies, IHttpClientFactory clientFactory)
        {
            _context = context;
            _contextItems = contextItems;
            _movies = movies;

            _clientFactory = clientFactory;
        }

        public ActionResult Index()
        {
            List<MovieList> movieLists = _context.Collection().ToList();
            ViewBag.Me = "You"; // ViewBag test

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
        public ActionResult ViewList(string list_id)
        {
            //MovieList movieList = _context.Collection().FirstOrDefault(i => i.ID == list_id);
            MovieList movieList = _context.Find(list_id);
            List<Movie> movies = GetMoviesInThisList(list_id);

            MovieListViewModel viewModel = new MovieListViewModel(movieList, movies);

            return View(viewModel);
        }

        [ActionName("Search")]
        public async Task<ActionResult> SearchAsync(string query)
        {
            //MovieList movieList = _context.Find(list_id);
            //List<Movie> allMovies = _movies.Collection().ToList();

            //MovieListViewModel viewModel = new MovieListViewModel(movieList, allMovies);

            await SearchTMDB(query);

            return View("~/Views/MovieLists/Search.cshtml", model:query);
        }

        [HttpPost]
        public ActionResult Add(string list_id, string movie_id)
        {
            MovieList movieList = _context.Find(list_id);
            Movie movie = _movies.Find(movie_id);

            MovieListItem listItem = new MovieListItem(list_id, movie_id);
            _contextItems.Insert(listItem);
            _contextItems.Commit();

            _context.Commit();

            return RedirectToAction("View", new { list_id });
        }

        [HttpPost]
        public ActionResult Remove(string list_id, string movie_id)
        {
            MovieList movieList = _context.Find(list_id);
            MovieListItem listItem = _contextItems.Collection().FirstOrDefault(i => (i.ListID==list_id && i.MovieID==movie_id));

            _contextItems.Delete(listItem.ID);
            _contextItems.Commit();

            return RedirectToAction("View", new { list_id });
        }

        public ActionResult Delete(string list_id)
        {
            var movieList = _context.Find(list_id);
            List<Movie> movies = GetMoviesInThisList(list_id);

            MovieListViewModel viewModel = new MovieListViewModel(movieList, movies);
            return View(viewModel);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult ConfirmDelete(string list_id)
        {
            List<string> listItemIDs = (from item in _contextItems.Collection()
                                             where item.ListID == list_id
                                             select item.ID).ToList();

            foreach (string id in listItemIDs)
            {
                _contextItems.Delete(id);
            }
            _contextItems.Commit();

            _context.Delete(list_id);
            _context.Commit();

            return RedirectToAction("Index");
        }

        #region helpers

        public List<Movie> GetMoviesInThisList(string list_id)
        {
            /*
             * Why not just grab the movies in the query? Because you can get multiple
             * concurrent calls to the SQLRepository so this is just the 'cleaner' way
             * of doing it.
             */

            List<string> movieIDs = (from listItem in _contextItems.Collection()
                                     where listItem.ListID == list_id
                                     select listItem.MovieID).ToList();

            List<Movie> movies = new List<Movie>();
            foreach (string s in movieIDs)
            {
                movies.Add(_movies.Find(s));
            }

            return movies;
        }

        public async Task SearchTMDB(string query)
        {
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get,
                "https://api.themoviedb.org/3/search/company?api_key=96176cdd887d42653dce0c4c94f56705&query=Fight&page=1");

            request.Headers.Add("Accept", "application/vnd.github.v3+json");
            request.Headers.Add("User-Agent", "HttpClientFactory-Sample");

            HttpClient client = _clientFactory.CreateClient();

            HttpResponseMessage response = await client.SendAsync(request);
            System.Diagnostics.Debug.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>RESPONSE: " + response.Content);

            string jsonString = await response.Content.ReadAsStringAsync();
            var json = JsonConvert.DeserializeObject<object>(jsonString);

            System.Diagnostics.Debug.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>JSON: " + json);
        }

        #endregion

    }

}
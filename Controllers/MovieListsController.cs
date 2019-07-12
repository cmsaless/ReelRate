using System;
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
        private IRepository<MovieList> _listContext;
        private IRepository<MovieListItem> _listItemsContext;
        private readonly IRepository<Movie> _allMoviesContext;

        private readonly IHttpClientFactory _clientFactory;

        public MovieListsController(IRepository<MovieList> context, IRepository<MovieListItem> contextItems, IRepository<Movie> movies, IHttpClientFactory clientFactory)
        {
            _listContext = context;
            _listItemsContext = contextItems;
            _allMoviesContext = movies;

            _clientFactory = clientFactory;
        }

        public ActionResult Index()
        {
            List<MovieList> movieLists = _listContext.Collection().ToList();

            return View(movieLists);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(MovieList movieList)
        {
            movieList.Size = 0;
            _listContext.Insert(movieList);
            _listContext.Commit();

            return RedirectToAction("Index");
        }

        [ActionName("View")]
        public ActionResult ViewList(string list_id)
        {
            MovieList movieList = _listContext.Find(list_id);
            List<(int, Movie)> rankedMovies = GetRankedMoviesOfList(list_id);

            MovieListViewModel viewModel = new MovieListViewModel(movieList, rankedMovies);
            return View(viewModel);
        }

        public ActionResult Search(string list_id)
        {
            MovieList movieList = _listContext.Find(list_id);

            ActionResult res;

            if (movieList.Size == 100)
            {
                res = RedirectToAction("View", new { list_id });
            } else
            {
                MovieListViewModel viewModel = new MovieListViewModel(movieList, new List<(int, Movie)>());
                res = View(viewModel);
                //ViewBag.ListID = list_id;
                //List<Movie> allMovies = _allMoviesContext.Collection().ToList();
                //res = View(allMovies);
            }

            return res;
        }

        [HttpPost, ActionName("Add")]
        public void AddMovie(string list_id, Movie movie)
        {
            MovieList movieList = _listContext.Find(list_id);
            Movie findMovie = _allMoviesContext.Collection().FirstOrDefault(i => i.TMDB_ID == movie.TMDB_ID);

            if (findMovie == null)
            {
                _allMoviesContext.Insert(movie);
                _allMoviesContext.Commit();
            } else
            {
                movie = findMovie;
            }

            if (_listItemsContext.Collection().FirstOrDefault(i => i.ListID==list_id && i.MovieID==movie.ID) == null)
            {
                MovieListItem listItem = new MovieListItem(list_id, movie.ID);

                movieList.IncrementSize();
                listItem.Rank = movieList.Size;

                _listItemsContext.Insert(listItem);
                _listItemsContext.Commit();

                _listContext.Update(movieList);
                _listContext.Commit();
            }

            //return RedirectToAction("View", new { list_id });
        }

        [HttpPost, ActionName("Remove")]
        public ActionResult RemoveMovie(string list_id, string movie_id)
        {
            MovieList movieList = _listContext.Find(list_id);
            MovieListItem listItem = _listItemsContext.Collection().FirstOrDefault(i => (i.ListID == list_id && i.MovieID == movie_id));

            _listItemsContext.Delete(listItem.ID);
            _listItemsContext.Commit();

            movieList.DecrementSize();
            _listContext.Update(movieList);
            _listContext.Commit();

            return RedirectToAction("View", new { list_id });
        }

        public ActionResult Delete(string list_id)
        {
            MovieList movieList = _listContext.Find(list_id);
            List<(int, Movie)> rankedMovies = GetRankedMoviesOfList(list_id);

            MovieListViewModel viewModel = new MovieListViewModel(movieList, rankedMovies);
            return View(viewModel);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult ConfirmDelete(string list_id)
        {
            List<string> listItemIDs = (from item in _listItemsContext.Collection()
                                        where item.ListID == list_id
                                        select item.ID).ToList();

            foreach (string id in listItemIDs)
            {
                _listItemsContext.Delete(id);
            }
            _listItemsContext.Commit();

            _listContext.Delete(list_id);
            _listContext.Commit();

            return RedirectToAction("Index");
        }

        [HttpPost, ActionName("Save")]
        public void SaveList(string list_id, string movie_id, string new_rank)
        {
            MovieList movieList = _listContext.Find(list_id);

            MovieListItem listItem = (from item in _listItemsContext.Collection()
                                      where item.ListID == list_id && item.MovieID == movie_id
                                      select item).FirstOrDefault();

            listItem.Rank = Convert.ToInt32(new_rank);
            _listItemsContext.Update(listItem);
            _listItemsContext.Commit();
        }

        #region helpers

        public List<(int, Movie)> GetRankedMoviesOfList(string list_id)
        {
            // Find all the MovieListItems associated with the requested MovieList.
            List<MovieListItem> movieListItems = (from item in _listItemsContext.Collection()
                                                  where item.ListID == list_id
                                                  select item).ToList();

            // Go find every Movie that has a matching MovieListItem, and add 
            // it to the rankedMovies list with its corresponding rank.
            List<(int, Movie)> rankedMovies = new List<(int, Movie)>();
            foreach (MovieListItem item in movieListItems)
            {
                rankedMovies.Add((item.Rank, _allMoviesContext.Find(item.MovieID)));
            }
            rankedMovies = rankedMovies.OrderBy(i => i.Item1).ToList();

            return rankedMovies;
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
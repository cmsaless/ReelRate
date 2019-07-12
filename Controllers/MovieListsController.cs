using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC.Contracts;
using MVC.Models;

namespace MVC.Controllers
{
    public class MovieListsController : Controller
    {
        private IRepository<MovieList> _listContext;
        private IRepository<MovieListItem> _listItemsContext;
        private readonly IRepository<Movie> _allMoviesContext;

        private readonly IHttpClientFactory _clientFactory;
        private readonly IHttpContextAccessor _httpContextAccessor;

        private readonly string _loggedInUserID;

        public MovieListsController(IRepository<MovieList> context, IRepository<MovieListItem> contextItems, IRepository<Movie> movies, IHttpClientFactory clientFactory, IHttpContextAccessor httpContextAccessor)
        {
            _listContext = context;
            _listItemsContext = contextItems;
            _allMoviesContext = movies;

            _clientFactory = clientFactory;
            _httpContextAccessor = httpContextAccessor;
            _loggedInUserID = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
        }

        [Authorize]
        public ActionResult Index()
        {
            List<MovieList> movieLists = (from item in _listContext.Collection()
                                          where item.AuthorID == _loggedInUserID
                                          select item).ToList();

            return View(movieLists);
        }

        [Authorize]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public ActionResult Create(MovieList movieList)
        {
            movieList.AuthorID = _loggedInUserID;
            movieList.Size = 0;
            _listContext.Insert(movieList);
            _listContext.Commit();

            return RedirectToAction("Index");
        }

        [ActionName("View")]
        [Authorize]
        public ActionResult ViewList(string list_id)
        {
            MovieList movieList = _listContext.Find(list_id);
            if (movieList.AuthorID != _loggedInUserID)
            {
                return RedirectToPage("~/Views/Shared/Error.cshtml");
            }

            List<(int, Movie)> rankedMovies = GetRankedMoviesOfList(list_id);
            MovieListViewModel viewModel = new MovieListViewModel(movieList, rankedMovies);

            return View(viewModel);
        }

        [Authorize]
        public ActionResult Search(string list_id)
        {
            MovieList movieList = _listContext.Find(list_id);
            if (movieList.AuthorID != _loggedInUserID)
            {
                return RedirectToPage("~/Views/Shared/Error.cshtml");
            }

            if (movieList.Size == 100)
            {
                return RedirectToAction("View", new { list_id });
            } else
            {
                MovieListViewModel viewModel = new MovieListViewModel(movieList, new List<(int, Movie)>());
                return View(viewModel);
            }
        }

        [HttpPost, ActionName("Add")]
        [Authorize]
        public void AddMovie(string list_id, Movie movie)
        {
            MovieList movieList = _listContext.Find(list_id);
            if (movieList.AuthorID != _loggedInUserID)
            {
                return;
            }

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
        }

        [HttpPost, ActionName("Remove")]
        [Authorize]
        public ActionResult RemoveMovie(string list_id, string movie_id)
        {
            MovieList movieList = _listContext.Find(list_id);
            if (movieList.AuthorID != _loggedInUserID)
            {
                return RedirectToPage("~/Views/Shared/Error.cshtml");
            }

            MovieListItem listItem = _listItemsContext.Collection().FirstOrDefault(i => (i.ListID == list_id && i.MovieID == movie_id));

            _listItemsContext.Delete(listItem.ID);
            _listItemsContext.Commit();

            movieList.DecrementSize();
            _listContext.Update(movieList);
            _listContext.Commit();

            return RedirectToAction("View", new { list_id });
        }

        [Authorize]
        public ActionResult Delete(string list_id)
        {
            MovieList movieList = _listContext.Find(list_id);
            if (movieList.AuthorID != _loggedInUserID)
            {
                return RedirectToPage("~/Views/Shared/Error.cshtml");
            }

            List<(int, Movie)> rankedMovies = GetRankedMoviesOfList(list_id);

            MovieListViewModel viewModel = new MovieListViewModel(movieList, rankedMovies);
            return View(viewModel);
        }

        [HttpPost, ActionName("Delete")]
        [Authorize]
        public ActionResult ConfirmDelete(string list_id)
        {
            MovieList movieList = _listContext.Find(list_id);
            if (movieList.AuthorID != _loggedInUserID)
            {
                return RedirectToPage("~/Views/Shared/Error.cshtml");
            }

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
        [Authorize]
        public void SaveList(string list_id, string movie_id, string new_rank)
        {
            MovieList movieList = _listContext.Find(list_id);
            if (movieList.AuthorID != _loggedInUserID)
            {
                return;
            }

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

        #endregion

    }

}
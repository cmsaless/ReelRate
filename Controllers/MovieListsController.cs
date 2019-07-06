﻿using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MVC.Contracts;
using MVC.Models;

namespace MVC.Controllers
{
    public class MovieListsController : Controller
    {
        private IRepository<MovieList> _context;
        private readonly IRepository<Movie> _movies;

        public MovieListsController(IRepository<MovieList> context, IRepository<Movie> movies)
        {
            _context = context;
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
            var movieList = _context.Find(ID);
            return View(movieList);
        }

        public ActionResult AddMovie(string ID)
        {
            var movieList = _context.Find(ID);

            AddMovieViewModel viewModel = new AddMovieViewModel(movieList, _movies.Collection());

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult AddMovie(string listID, string movieID)
        {
            var movie = _movies.Find(movieID);
            var movieList = _context.Find(listID);

            movieList.Movies.Add(movie);
            _context.Commit();

            return RedirectToAction("Index");
        }
    }

}
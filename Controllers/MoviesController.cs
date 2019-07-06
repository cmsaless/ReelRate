﻿using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MVC.Contracts;
using MVC.Models;

namespace MVC.Controllers
{
    public class MoviesController : Controller
    {
        private IRepository<Movie> _context;

        public MoviesController(IRepository<Movie> context)
        {
            _context = context;
        }

        public ActionResult Index()
        {
            List<Movie> movies = _context.Collection().ToList();
            return View(movies);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Movie movie)
        {
            if (!ModelState.IsValid)
            {
                return View(movie);
            }

            _context.Insert(movie);
            _context.Commit();

            return RedirectToAction("Index");
        }

        public ActionResult Delete(string ID)
        {
            var movie = _context.Find(ID);
            return View(movie);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult ConfirmDelete(string ID)
        {
            _context.Delete(ID);
            _context.Commit();
            return RedirectToAction("Index");
        }
    }
}
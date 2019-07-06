using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
    }
}
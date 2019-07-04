using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ReelRate.WebUI.Contracts;
using ReelRate.WebUI.Models;

namespace ReelRate.WebUI.Controllers
{
    public class MoviesController : Controller
    {
        private readonly IRepository<Movie> _context;

        public MoviesController(IRepository<Movie> context)
        {
            _context = context;
        }

        // GET: www.site.com/Movies
        public ActionResult Index()
        {
            List<Movie> movies = _context.Collection().ToList();
            return View(movies);
        }

        // GET: /Movies/Create
        public ActionResult Create()
        {
            return View(new Movie());
        }

        // POST: /Movies/Create
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

        //    // GET: Movies/Details/5
        //    public async Task<IActionResult> Details(string id)
        //    {
        //        if (id == null)
        //        {
        //            return NotFound();
        //        }

        //        var movie = await _context.Movie
        //            .FirstOrDefaultAsync(m => m.ID == id);
        //        if (movie == null)
        //        {
        //            return NotFound();
        //        }

        //        return View(movie);
        //    }

        //    // GET: Movies/Create
        //    public IActionResult Create()
        //    {
        //        return View();
        //    }

        //    // POST: Movies/Create
        //    // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //    // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //    [HttpPost]
        //    [ValidateAntiForgeryToken]
        //    public async Task<IActionResult> Create([Bind("ID,CreatedAt")] Movie movie)
        //    {
        //        if (ModelState.IsValid)
        //        {
        //            _context.Add(movie);
        //            await _context.SaveChangesAsync();
        //            return RedirectToAction(nameof(Index));
        //        }
        //        return View(movie);
        //    }

        //    // GET: Movies/Edit/5
        //    public async Task<IActionResult> Edit(string id)
        //    {
        //        if (id == null)
        //        {
        //            return NotFound();
        //        }

        //        var movie = await _context.Movie.FindAsync(id);
        //        if (movie == null)
        //        {
        //            return NotFound();
        //        }
        //        return View(movie);
        //    }

        //    // POST: Movies/Edit/5
        //    // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //    // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //    [HttpPost]
        //    [ValidateAntiForgeryToken]
        //    public async Task<IActionResult> Edit(string id, [Bind("ID,CreatedAt")] Movie movie)
        //    {
        //        if (id != movie.ID)
        //        {
        //            return NotFound();
        //        }

        //        if (ModelState.IsValid)
        //        {
        //            try
        //            {
        //                _context.Update(movie);
        //                await _context.SaveChangesAsync();
        //            }
        //            catch (DbUpdateConcurrencyException)
        //            {
        //                if (!MovieExists(movie.ID))
        //                {
        //                    return NotFound();
        //                }
        //                else
        //                {
        //                    throw;
        //                }
        //            }
        //            return RedirectToAction(nameof(Index));
        //        }
        //        return View(movie);
        //    }

        //    // GET: Movies/Delete/5
        //    public async Task<IActionResult> Delete(string id)
        //    {
        //        if (id == null)
        //        {
        //            return NotFound();
        //        }

        //        var movie = await _context.Movie
        //            .FirstOrDefaultAsync(m => m.ID == id);
        //        if (movie == null)
        //        {
        //            return NotFound();
        //        }

        //        return View(movie);
        //    }

        //    // POST: Movies/Delete/5
        //    [HttpPost, ActionName("Delete")]
        //    [ValidateAntiForgeryToken]
        //    public async Task<IActionResult> DeleteConfirmed(string id)
        //    {
        //        var movie = await _context.Movie.FindAsync(id);
        //        _context.Movie.Remove(movie);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }

        //    private bool MovieExists(string id)
        //    {
        //        return _context.Movie.Any(e => e.ID == id);
        //    }
    }
}

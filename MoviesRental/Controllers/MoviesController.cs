using MoviesRental.Models;
using MoviesRental.ViewModels;
using MoviesRental.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

using System.Data.Entity;




namespace MoviesRental.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult New()
        {
            var genres = _context.Genres.ToList();
            var viewModel = new MovieFormViewModel()
            {
                Genres = genres
            };

            return View("MovieForm", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Movie movie)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new MovieFormViewModel(movie)
                {                    
                    Genres = _context.Genres.ToList()
                };

                return View("MovieForm", viewModel);
            }

            if (movie.Id == 0)
            {
                movie.DateAdded = DateTime.Now;
                _context.Movies.Add(movie);
            }
                
            else                        
            {
                var movieInDb = _context.Movies.Single(m => m.Id == movie.Id);
                movieInDb.Name = movie.Name;
                movieInDb.GenreId = movie.GenreId;              
                movieInDb.NumberInStock = movie.NumberInStock;
                movieInDb.ReleaseDate = movie.ReleaseDate;
            }
            _context.SaveChanges();            

            return RedirectToAction("Index", "Movies");
        }

        
        [System.Web.Mvc.Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
           

        public ActionResult Edit(int id)
        {
            var movie = _context.Movies.SingleOrDefault(c => c.Id == id);

            if (movie == null)
                return HttpNotFound();

            var viewModel = new MovieFormViewModel(movie)
            {               
                Genres = _context.Genres.ToList()
            };

            return View("MovieForm", viewModel);
        }


        //movies
        //public ActionResult Index(int? pageIndex, string sortBy)
        public ActionResult Index()
        {
            return View();           
        }

        public ActionResult Details(int id)
        {
            {
                var movie = _context.Movies.Include(m => m.Genre).SingleOrDefault(m => m.Id == id);
                if (movie == null) 
                    return HttpNotFound();                
                return View(movie);
            }
        }

        //private IEnumerable<Movie> GetMovies()
        //{
        //    return new List<Movie>
        //    {
        //        new Movie { Id = 1, Name = "Terminator 2" },
        //        new Movie { Id = 2, Name = "Back to the future" }
        //    };
        //}
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using DemoMvc.Models;
using System.Linq;
using System.Collections.Generic;
namespace DemoMvc.Controllers

{
    public class MovieController : Controller
    {
        public IActionResult Info()
        {
           Movie movie = new Movie { Id = 1, Title = "War", Year = 2019, Rating = 4 };
            return View(movie);
        }
        public IActionResult Search()
        {
            return View();
        }
        public IActionResult List()
        {
            List<Movie> movies = GetMovies();
            return View(movies);
        }
        public List<Movie> GetMovies()
        {
            List<Movie> movies = new List<Movie>
            {
            new Movie { Id = 1, Title = "War", Year = 2019, Rating = 4 },
            new Movie { Id = 2, Title = "Puspa", Year = 2022, Rating = 3 },
            new Movie { Id = 3, Title = "DDLJ", Year = 1996, Rating = 4 },
            new Movie { Id = 4, Title = "YJHD", Year = 2016, Rating = 3 },
            new Movie { Id = 5, Title = "Cooloe no 1", Year = 2021, Rating = 1 }
            };
            return movies;
        }

        public IActionResult Find(int id)
        {
            List<Movie> movies = GetMovies();
            Movie data = movies.Where(movies => movies.Id == id).FirstOrDefault();
            return View("Info", data);

        }
        [HttpGet]
        public IActionResult FindByRating()
        {
            List<int> ratinglist = new List<int> { 1, 2, 3, 4, 5 };
            ViewBag.rating = new SelectList(ratinglist);
            return View();  //should go with http Post
        }
        [HttpPost]
        public IActionResult FindByRating(int rating)
        {
            List<Movie> movies = GetMovies();
            var data = movies.Where(m => m.Rating == rating);
            ViewBag.MovieList = data;
            List<int> ratinglist = new List<int> { 1, 2, 3, 4, 5 };
            ViewBag.rating = new SelectList(ratinglist);
            return View();
        }
    }
}

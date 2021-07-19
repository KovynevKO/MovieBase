using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MovieBase.Models;
using MovieBase.Models.Repository;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MovieBase.Controllers
{
    public class HomeController : Controller
    {
        private IMovieRepository movieRepository;
        public HomeController(IMovieRepository repository)
        {
            movieRepository = repository;
        }

        public IActionResult Index()
        {
            return View(movieRepository.GetMovies());
        }

        public async Task<IActionResult> Movie(int id)
        {
            Movie movie = await movieRepository.GetMovieFullInfo(id);
            return View(movie);
        }

    }
}

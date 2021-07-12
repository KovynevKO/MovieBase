using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MovieBase.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MovieBase.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db;
        public HomeController(ApplicationDbContext context)
        {
            db = context;
            
        }

        public IActionResult Index()
        {
            ViewBag.IsUserInRole = User?.Identity?.IsAuthenticated;
            if (ViewBag.IsUserInRole == null)
                ViewBag.IsUserInRole = false;

            return View(db.Movies.ToList());
        }

    }
}

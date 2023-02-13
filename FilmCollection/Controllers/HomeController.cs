using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using FilmCollection.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FilmCollection.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private FilmDataContext _filmContext { get; set; }

        public HomeController(ILogger<HomeController> logger, FilmDataContext filmContext)
        {
            _logger = logger;
            _filmContext = filmContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Podcasts()
        {
            return View();
        }

        //for when the form gets rendered to have data entered
        [HttpGet]
        public IActionResult MovieForm()
        {
            return View();
        }

        //When a form is submitted it becomes a POST and redirects the page to "Confirmation", this also saves the film to the sqlite db
        [HttpPost]
        public IActionResult MovieForm(FilmData film)
        {
            _filmContext.Add(film);
            _filmContext.SaveChanges();

            return View("Confirmation", film);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

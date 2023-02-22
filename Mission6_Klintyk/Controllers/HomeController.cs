using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Mission6_Klintyk.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6_Klintyk.Controllers
{
    public class HomeController : Controller
    {
   
        //constructor
        private MovieContext _filmContext { get; set; }

        public HomeController(MovieContext someName)
        {
            _filmContext = someName;
        }
       
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Podcasts()
        {
            return View();
        }
        [HttpGet]
        public IActionResult NewMovie()
        {
            ViewBag.Categories = _filmContext.Categories.ToList();

            return View();
        }
        [HttpPost]
        public IActionResult NewMovie(Movie model)
        {
            _filmContext.Add(model);
            _filmContext.SaveChanges();
            return View("Confirmation", model);
        }
       

        //displays the collection of films
        public IActionResult DisplayMovie()
        {
            var films =_filmContext.Responses
                .Include(x => x.Category)
                .OrderBy(x=>x.Year)
                .ToList();
            return View(films);
        }
       
    }
}

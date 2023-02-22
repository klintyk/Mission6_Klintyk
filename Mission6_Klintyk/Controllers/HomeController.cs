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
            if (ModelState.IsValid)
            {
            _filmContext.Add(model);
            _filmContext.SaveChanges();
            return View("Confirmation", model);
            }
            else //if not valid
            {
                ViewBag.Categories = _filmContext.Categories.ToList();
                return View(model);
            }
            
        }
       

        //displays the collection of films
        [HttpGet]
        public IActionResult DisplayMovie()
        {
            var films =_filmContext.Responses
                .Include(x => x.Category)
                .OrderBy(x=>x.Year)
                .ToList();
            return View(films);
        }
        [HttpGet]
        public IActionResult EditFilm(int filmid)
        {
            //send viewbag to this page
            ViewBag.Categories = _filmContext.Categories.ToList();
            var film = _filmContext.Responses.Single(x => x.FilmID == filmid);
            return View("NewMovie", film);
        }

        [HttpPost]
        public IActionResult EditFilm(Movie film)
        {
            _filmContext.Update(film);
            _filmContext.SaveChanges();

            return RedirectToAction("DisplayMovie");
        }
        [HttpGet]
        public IActionResult DeleteFilm(int filmid)
        {
            var film = _filmContext.Responses.Single(x => x.FilmID == filmid);
            return View(film);
        }
        [HttpPost]
        public IActionResult DeleteFilm(Movie mv)
        {
            _filmContext.Responses.Remove(mv);
            _filmContext.SaveChanges();
            return RedirectToAction("DisplayMovie");
        }
    }
}

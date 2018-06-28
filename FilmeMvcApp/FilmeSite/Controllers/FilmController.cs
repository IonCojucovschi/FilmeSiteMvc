using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FilmeLibraryService.Models;

namespace FilmeSite.Controllers
{
    public class FilmController : Controller
    {
        public ActionResult Index()
        {
            return Redirect("/Home/Index/");
        }
        [HttpGet]
        public ActionResult AddFilm()
        {
            return View();
        }
        [HttpPut]
        public ActionResult AddFilm(Film film)
        {
            FilmeLibraryService.Services.FilmeServices.AddFilm(film);
            return RedirectToAction("Index");
        }

    }
}

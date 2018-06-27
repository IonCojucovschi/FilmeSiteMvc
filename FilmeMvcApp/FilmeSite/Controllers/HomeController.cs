using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using FilmeLibraryService.Models;
using FilmeLibraryService.Services;

namespace FilmeSite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = FilmeServices.GetAll().Take(15).ToList<Film>();

            return View(model);
        }
        public ActionResult CategoryView()
        {
            var model = FilmeServices.GetAllCategory();

           return PartialView("_CategoryView",model);
        }
    }
}

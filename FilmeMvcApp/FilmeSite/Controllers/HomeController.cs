using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using FilmeLibraryService.Models;
using FilmeLibraryService.Services;
using PagedList;
using PagedList.Mvc;
namespace FilmeSite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(int? page)
        {
            var model = FilmeServices.GetAll().ToList<Film>().ToPagedList(page ?? 1,6);

            return View(model);
        }

        public ActionResult CategoryContent(string categ,int? page)
        {
            ViewBag.Categ = categ;
            
            var model = FilmeServices.GetByCategory(categ).ToList().ToPagedList(page ?? 1, 6);


            return View(model);
        }

        public ActionResult FilmDetail(int id)
        {
            var model = FilmeServices.GetById(id);

            return View(model);
        }

        ////partial views
        public ActionResult CategoryView()
        {
            var model = FilmeServices.GetAllCategory();

            return PartialView("_CategoryView", model);
        }
        public ActionResult FilmView(Film model)
        {
            return PartialView("_FilmView", model);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using FilmeLibraryService.Models;
using FilmeLibraryService.Services;
using FilmeSite.Models;

namespace FilmeSite.Controllers
{
    public class yellowPageController : ApiController
    {
        public IHttpActionResult Index()
        {
            return Ok();
        }
        [Route("KPMGYP/yellowPage/ricerca")]
        [HttpGet]
        public IHttpActionResult ricerca(string cognome = "", string nome = "", string posizione = "", string societa = "", string solution = "")
        {
            if (cognome == null) cognome = "";
            if (nome == null) nome = "";
            if (posizione == null) posizione = "";
            if (societa == null) societa = "";

            if ((cognome == null & nome == null & posizione == null & societa == null) | (cognome == "" & nome == "" & posizione == "" & societa == "")) return Json(new List<Custommer>());



            List<Custommer> custommers = FilmeServices.GetByCustomerProp();
            if (cognome == null | nome == null | posizione == null | societa == null | solution == null)
                return Json(custommers);

            List<RicercaModel> sel = custommers.Where(el => el.cognome.Contains(cognome) & el.societa.Contains(societa) & el.solution.Contains(solution))
                                               .Select(p => new RicercaModel()
                                               {
                                                   nome = p.nome,
                                                   cognome = p.cognome,
                                                   posizione = p.posizione,
                                                   citta = p.citta,
                                                   mail = p.mail,
                                                   societa = p.societa,
                                                   solution = p.solution
                                               }).ToList();

            //return Ok(Json(sel));
            return Json(sel);

        }
        [Route("KPMGYP/yellowPage/getContatto")]
        public IHttpActionResult getContatto(string cognome = "", string mail = "", string nome = "")
        {
            if (cognome == null) return Ok();
            if (mail == null) return Ok();
            if (nome == null) return Ok();

            if ((cognome == null & mail == null & nome == null) | (cognome == "" & mail == "" & nome == "")) return Ok();

            Custommer cust = FilmeServices.GetByCustomerProp().Where(prop => prop.cognome == cognome | prop.mail == mail | prop.nome == nome).FirstOrDefault();
            return Json(cust);

        }




    }
}

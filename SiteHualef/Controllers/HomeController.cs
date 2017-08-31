using SiteHualef.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SiteHualef.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public JsonResult BuscarListaDeShows()
        {
            List<Show> lista = new List<Show>();
            lista.Add(new Show { idShow = 1, data = DateTime.Now, cidade = "Serra", qtdPessoas = 1000 });
            lista.Add(new Show { idShow = 2, data = DateTime.Now, cidade = "Cariacica", qtdPessoas = 2000 });
            lista.Add(new Show { idShow = 3, data = DateTime.Now, cidade = "Vitória", qtdPessoas = 3000 });
            lista.Add(new Show { idShow = 4, data = DateTime.Now, cidade = "Vila Velha", qtdPessoas = 4000 });

            return Json(lista, JsonRequestBehavior.AllowGet);
        }
    }
}
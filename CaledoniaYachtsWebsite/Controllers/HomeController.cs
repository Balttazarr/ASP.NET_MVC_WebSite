using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CaledoniaYachtsWebsite.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Model3D()
        {
            return View();
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "O stronie i twórcy po krótce.";

            return View();
        }

        public ActionResult Kontakt()
        {
            ViewBag.Message = "Zachęcamy do kontaktu w godzinach 6-18 czy coś.";

            return View();
        }

        public ActionResult Oferta()
        {
            return View();
        }

        public ActionResult Realizacje()
        {
            ViewBag.Message = "Na tej stronie znajdują się moje wybrane realizacje.";
            return View();
        }
        public ActionResult Historia()
        {
            return View();
        }
        public ActionResult Profil()
        {
            return View();
        }


    }
}
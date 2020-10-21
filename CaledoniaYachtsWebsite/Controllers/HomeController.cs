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
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Kontakt()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Oferta()
        {
            return View();
        }

        public ActionResult Realizacje()
        {
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
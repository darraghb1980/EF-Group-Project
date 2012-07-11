using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using teamcanada.Models;

namespace teamcanada.Controllers
{
    public class HomeController : Controller
    {
        public torontoDb db = new torontoDb();
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to Team Canada!.";
            List<Results> results = db.results.ToList();
            return View(results);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using teamcanada.ingestion;
using teamcanada.Models;
using teamcanada.dal;
using System.Data.Entity;

namespace teamcanada.Controllers
{
    public class HomeController : Controller
    {
        public torontoDB torontoDB = new torontoDB();

        public ActionResult Index()
        {
           // ViewBag.Message = "Welcome to Team Canada!.";

            return View(torontoDB.ElectionResults.ToList());

           // return View();
        }
            
        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            //torontoDAL.insertcsv();   

          return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}

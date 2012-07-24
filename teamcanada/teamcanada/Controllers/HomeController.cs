using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using teamcanada.dal;
using teamcanada.ingestion;
using teamcanada.Models;


namespace teamcanada.Controllers
{
    public class HomeController : Controller
    {

        //create reference to database
        public torontoDB torontoDB = new torontoDB();

        public ActionResult Index()
        {
           ViewBag.Message = "Welcome to Team Canada!.";

           return View();
        }
            
        public ActionResult ViewResults()
        {
            ViewBag.Message = "View a list of all Election Results.";

          return View();
        }

        public ActionResult ViewContributions()
        {
            ViewBag.Message = "View a list of all Election Contributions.";

            return View();
        }

        public ActionResult ViewSavedReports()
        {
            ViewBag.Message = "View any saved reports.";

            return View();
        }

    }
}
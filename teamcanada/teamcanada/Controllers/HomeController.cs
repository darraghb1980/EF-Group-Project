using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using teamcanada.dal;
using teamcanada.ingestion;
using teamcanada.Models;
using teamcanada.Models.ui;

namespace teamcanada.Controllers
{
    public class HomeController : Controller
    {
        public torontoDB torontoDB = new torontoDB();

        public ActionResult Index()
        {
            /* Get the type of election from one of the tables so we can pass them to the drop down list on the view */
            /* .Distinct() means it only takes the distinct values, i.e. the two values */

            var db = new torontoDB();
            IEnumerable<SelectListItem> etype = db.ElectionResults.Select(t => new SelectListItem             
            { Value = t.ElectionType, Text = t.ElectionType }).Distinct();

            ViewBag.ElectionType = etype;

            /* Get the year of election from one of the tables so we can pass them to the drop down list on the view 

            IEnumerable<SelectListItem> eyear = db.ElectionResults.Select(y => new SelectListItem

            {
                Value = y.ElectionYear,
                Text = y.ElectionYear
            }).ToString().Distinct();

            ViewBag.ElectionYear = eyear;
             
             */

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
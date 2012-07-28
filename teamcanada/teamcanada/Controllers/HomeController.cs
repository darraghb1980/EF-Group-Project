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

            // Get the year of election from one of the tables so we can pass them to the drop down list on the view 

            IEnumerable<SelectListItem> eyear = db.ElectionResults.AsEnumerable().Select(y => y.ElectionYear).Distinct().Select(y => new SelectListItem

            {
                Value = y.ToString(),
                Text = y.ToString()
            });

            ViewBag.ElectionYear = eyear;

            IEnumerable<SelectListItem> wnum = db.ElectionResults.AsEnumerable().Select(x => x.WardNum).Distinct().Select(x => new SelectListItem
            {
                Value = x.ToString(),
                Text = x.ToString()
            });

            ViewBag.WardNum = wnum;

            IEnumerable<SelectListItem> lname = db.ElectionContributions.AsEnumerable().Select(x => x.CandidateLastName).Distinct().Select(x => new SelectListItem
            {
                Value = x.ToString(),
                Text = x.ToString()
            });

            ViewBag.CandidateLastName = lname;

            IEnumerable<SelectListItem> cname = db.ElectionContributions.AsEnumerable().Select(x => x.ContributionTypeDesc).Distinct().Select(x => new SelectListItem
            {
                Value = x.ToString(),
                Text = x.ToString()
            });

            ViewBag.ContributionTypeDesc = cname;


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
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using teamcanada.Models.ui;
using teamcanada.Models;
using teamcanada.dal;

namespace teamcanada.Controllers
{
    public class UserReportsController : Controller
    {
        private torontoDB db = new torontoDB();

        //
        // GET: /UserReports

        public ActionResult Index(string ElectionType, int ElectionYear, int WardNum, String CandidateLastName, string ContributionTypeDesc)
        {
            return View(UserReportsDAL.GetReportData(ElectionType, ElectionYear, WardNum, CandidateLastName, ContributionTypeDesc));
        }
    }
}
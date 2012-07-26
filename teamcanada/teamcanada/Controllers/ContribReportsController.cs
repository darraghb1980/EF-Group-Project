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
    public class ContribReportsController : Controller
    {
        private torontoDB db = new torontoDB();

        //
        // GET: /Reports/

        public ActionResult Report1()
        {
            return View(ContribReportsDAL.GetReportData());
        }

        public ActionResult Report2()
        {
            return View(ContribReportsDAL.GetReportData2());
        }


        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}
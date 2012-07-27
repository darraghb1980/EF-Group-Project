using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using teamcanada.Models.ui;
using teamcanada.Models;

namespace teamcanada.Controllers
{
    public class UserReportsController : Controller
    {
        private torontoDB db = new torontoDB();

        //
        // GET: /UserReports/Submit

        /* public ActionResult Submit()
        {
            if (ModelState.IsValid)
            {
                db.ReportsUI.Add(reportsui);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(reportsui);
        } */

        //
        // GET: /UserReports/Details/5

        public ActionResult Details(int id = 0)
        {
            ReportsUI reportsui = db.ReportsUI.Find(id);
            if (reportsui == null)
            {
                return HttpNotFound();
            }
            return View(reportsui);
        }

        //
        // GET: /UserReports/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /UserReports/Create

        [HttpPost]
        public ActionResult Create(ReportsUI reportsui)
        {
            if (ModelState.IsValid)
            {
                db.ReportsUI.Add(reportsui);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(reportsui);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}
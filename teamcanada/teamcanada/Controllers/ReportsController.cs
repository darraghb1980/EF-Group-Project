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
    public class ReportsController : Controller
    {
        private torontoDB db = new torontoDB();

        //
        // GET: /Reports/

        public ActionResult Index()
        {
            return View(ReportsDAL.GetReportData());
        }

        //
        // GET: /Reports/Details/5

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
        // GET: /Reports/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Reports/Create

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

        //
        // GET: /Reports/Edit/5

        public ActionResult Edit(int id = 0)
        {
            ReportsUI reportsui = db.ReportsUI.Find(id);
            if (reportsui == null)
            {
                return HttpNotFound();
            }
            return View(reportsui);
        }

        //
        // POST: /Reports/Edit/5

        [HttpPost]
        public ActionResult Edit(ReportsUI reportsui)
        {
            if (ModelState.IsValid)
            {
                db.Entry(reportsui).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(reportsui);
        }

        //
        // GET: /Reports/Delete/5

        public ActionResult Delete(int id = 0)
        {
            ReportsUI reportsui = db.ReportsUI.Find(id);
            if (reportsui == null)
            {
                return HttpNotFound();
            }
            return View(reportsui);
        }

        //
        // POST: /Reports/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            ReportsUI reportsui = db.ReportsUI.Find(id);
            db.ReportsUI.Remove(reportsui);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}
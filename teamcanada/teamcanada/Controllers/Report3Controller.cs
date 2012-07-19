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
    public class Report3Controller : Controller
    {
        private torontoDB db = new torontoDB();

        //
        // GET: /Report3/

        public ActionResult Index()
        {
            return View(db.Report3UI.ToList());
        }

        //
        // GET: /Report3/Details/5

        public ActionResult Details(int id = 0)
        {
            Report3UI report3ui = db.Report3UI.Find(id);
            if (report3ui == null)
            {
                return HttpNotFound();
            }
            return View(report3ui);
        }

        //
        // GET: /Report3/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Report3/Create

        [HttpPost]
        public ActionResult Create(Report3UI report3ui)
        {
            if (ModelState.IsValid)
            {
                db.Report3UI.Add(report3ui);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(report3ui);
        }

        //
        // GET: /Report3/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Report3UI report3ui = db.Report3UI.Find(id);
            if (report3ui == null)
            {
                return HttpNotFound();
            }
            return View(report3ui);
        }

        //
        // POST: /Report3/Edit/5

        [HttpPost]
        public ActionResult Edit(Report3UI report3ui)
        {
            if (ModelState.IsValid)
            {
                db.Entry(report3ui).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(report3ui);
        }

        //
        // GET: /Report3/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Report3UI report3ui = db.Report3UI.Find(id);
            if (report3ui == null)
            {
                return HttpNotFound();
            }
            return View(report3ui);
        }

        //
        // POST: /Report3/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Report3UI report3ui = db.Report3UI.Find(id);
            db.Report3UI.Remove(report3ui);
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
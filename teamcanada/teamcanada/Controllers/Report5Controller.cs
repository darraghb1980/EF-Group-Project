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
    public class Report5Controller : Controller
    {
        private torontoDB db = new torontoDB();

        //
        // GET: /Report5/

        public ActionResult Index()
        {
            return View(db.Report5UI.ToList());
        }

        //
        // GET: /Report5/Details/5

        public ActionResult Details(int id = 0)
        {
            Report5UI report5ui = db.Report5UI.Find(id);
            if (report5ui == null)
            {
                return HttpNotFound();
            }
            return View(report5ui);
        }

        //
        // GET: /Report5/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Report5/Create

        [HttpPost]
        public ActionResult Create(Report5UI report5ui)
        {
            if (ModelState.IsValid)
            {
                db.Report5UI.Add(report5ui);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(report5ui);
        }

        //
        // GET: /Report5/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Report5UI report5ui = db.Report5UI.Find(id);
            if (report5ui == null)
            {
                return HttpNotFound();
            }
            return View(report5ui);
        }

        //
        // POST: /Report5/Edit/5

        [HttpPost]
        public ActionResult Edit(Report5UI report5ui)
        {
            if (ModelState.IsValid)
            {
                db.Entry(report5ui).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(report5ui);
        }

        //
        // GET: /Report5/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Report5UI report5ui = db.Report5UI.Find(id);
            if (report5ui == null)
            {
                return HttpNotFound();
            }
            return View(report5ui);
        }

        //
        // POST: /Report5/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Report5UI report5ui = db.Report5UI.Find(id);
            db.Report5UI.Remove(report5ui);
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
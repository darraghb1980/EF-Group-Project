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
    public class Report2Controller : Controller
    {
        private torontoDB db = new torontoDB();

        //
        // GET: /Report2/

        public ActionResult Index()
        {
            return View(db.Report2UI.ToList());
        }

        //
        // GET: /Report2/Details/5

        public ActionResult Details(int id = 0)
        {
            Report2UI report2ui = db.Report2UI.Find(id);
            if (report2ui == null)
            {
                return HttpNotFound();
            }
            return View(report2ui);
        }

        //
        // GET: /Report2/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Report2/Create

        [HttpPost]
        public ActionResult Create(Report2UI report2ui)
        {
            if (ModelState.IsValid)
            {
                db.Report2UI.Add(report2ui);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(report2ui);
        }

        //
        // GET: /Report2/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Report2UI report2ui = db.Report2UI.Find(id);
            if (report2ui == null)
            {
                return HttpNotFound();
            }
            return View(report2ui);
        }

        //
        // POST: /Report2/Edit/5

        [HttpPost]
        public ActionResult Edit(Report2UI report2ui)
        {
            if (ModelState.IsValid)
            {
                db.Entry(report2ui).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(report2ui);
        }

        //
        // GET: /Report2/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Report2UI report2ui = db.Report2UI.Find(id);
            if (report2ui == null)
            {
                return HttpNotFound();
            }
            return View(report2ui);
        }

        //
        // POST: /Report2/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Report2UI report2ui = db.Report2UI.Find(id);
            db.Report2UI.Remove(report2ui);
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
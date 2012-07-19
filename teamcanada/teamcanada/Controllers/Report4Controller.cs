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
    public class Report4Controller : Controller
    {
        private torontoDB db = new torontoDB();

        //
        // GET: /Report4/

        public ActionResult Index()
        {
            return View(db.Report4UI.ToList());
        }

        //
        // GET: /Report4/Details/5

        public ActionResult Details(int id = 0)
        {
            Report4UI report4ui = db.Report4UI.Find(id);
            if (report4ui == null)
            {
                return HttpNotFound();
            }
            return View(report4ui);
        }

        //
        // GET: /Report4/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Report4/Create

        [HttpPost]
        public ActionResult Create(Report4UI report4ui)
        {
            if (ModelState.IsValid)
            {
                db.Report4UI.Add(report4ui);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(report4ui);
        }

        //
        // GET: /Report4/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Report4UI report4ui = db.Report4UI.Find(id);
            if (report4ui == null)
            {
                return HttpNotFound();
            }
            return View(report4ui);
        }

        //
        // POST: /Report4/Edit/5

        [HttpPost]
        public ActionResult Edit(Report4UI report4ui)
        {
            if (ModelState.IsValid)
            {
                db.Entry(report4ui).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(report4ui);
        }

        //
        // GET: /Report4/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Report4UI report4ui = db.Report4UI.Find(id);
            if (report4ui == null)
            {
                return HttpNotFound();
            }
            return View(report4ui);
        }

        //
        // POST: /Report4/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Report4UI report4ui = db.Report4UI.Find(id);
            db.Report4UI.Remove(report4ui);
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
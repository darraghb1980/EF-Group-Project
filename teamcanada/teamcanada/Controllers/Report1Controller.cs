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
    public class Report1Controller : Controller
    {
        private torontoDB db = new torontoDB();

        //
        // GET: /Report1/

        public ActionResult Index()
        {
            return View(db.ResultsUIs.ToList());
        }

        //
        // GET: /Report1/Details/5

        public ActionResult Details(int id = 0)
        {
            Report1UI report1ui = db.ResultsUIs.Find(id);
            if (report1ui == null)
            {
                return HttpNotFound();
            }
            return View(report1ui);
        }

        //
        // GET: /Report1/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Report1/Create

        [HttpPost]
        public ActionResult Create(Report1UI report1ui)
        {
            if (ModelState.IsValid)
            {
                db.ResultsUIs.Add(report1ui);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(report1ui);
        }

        //
        // GET: /Report1/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Report1UI report1ui = db.ResultsUIs.Find(id);
            if (report1ui == null)
            {
                return HttpNotFound();
            }
            return View(report1ui);
        }

        //
        // POST: /Report1/Edit/5

        [HttpPost]
        public ActionResult Edit(Report1UI report1ui)
        {
            if (ModelState.IsValid)
            {
                db.Entry(report1ui).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(report1ui);
        }

        //
        // GET: /Report1/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Report1UI report1ui = db.ResultsUIs.Find(id);
            if (report1ui == null)
            {
                return HttpNotFound();
            }
            return View(report1ui);
        }

        //
        // POST: /Report1/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Report1UI report1ui = db.ResultsUIs.Find(id);
            db.ResultsUIs.Remove(report1ui);
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
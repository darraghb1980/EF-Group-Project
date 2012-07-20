using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using teamcanada.Models;

namespace teamcanada.Controllers
{
    public class ResultsController : Controller
    {
        private torontoDB db = new torontoDB();

        //
        // GET: /Results/

        public ActionResult Index()
        {
            return View(db.ElectionResults.ToList());
        }

        //
        // GET: /Results/Details/5

        public ActionResult Details(int id = 0)
        {
            Results results = db.ElectionResults.Find(id);
            if (results == null)
            {
                return HttpNotFound();
            }
            return View(results);
        }

        //
        // GET: /Results/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Results/Create

        [HttpPost]
        public ActionResult Create(Results results)
        {
            if (ModelState.IsValid)
            {
                db.ElectionResults.Add(results);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(results);
        }

        //
        // GET: /Results/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Results results = db.ElectionResults.Find(id);
            if (results == null)
            {
                return HttpNotFound();
            }
            return View(results);
        }

        //
        // POST: /Results/Edit/5

        [HttpPost]
        public ActionResult Edit(Results results)
        {
            if (ModelState.IsValid)
            {
                db.Entry(results).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(results);
        }

        //
        // GET: /Results/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Results results = db.ElectionResults.Find(id);
            if (results == null)
            {
                return HttpNotFound();
            }
            return View(results);
        }

        //
        // POST: /Results/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Results results = db.ElectionResults.Find(id);
            db.ElectionResults.Remove(results);
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
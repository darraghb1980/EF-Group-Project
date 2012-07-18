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
    public class ContributionsController : Controller
    {
        private torontoDB db = new torontoDB();

        //
        // GET: /Contributions/

        public ActionResult Index()
        {
            return View(db.ElectionContributions.ToList());
        }

        //
        // GET: /Contributions/Details/5

        public ActionResult Details(int id = 0)
        {
            Contributions contributions = db.ElectionContributions.Find(id);
            if (contributions == null)
            {
                return HttpNotFound();
            }
            return View(contributions);
        }

        //
        // GET: /Contributions/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Contributions/Create

        [HttpPost]
        public ActionResult Create(Contributions contributions)
        {
            if (ModelState.IsValid)
            {
                db.ElectionContributions.Add(contributions);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(contributions);
        }

        //
        // GET: /Contributions/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Contributions contributions = db.ElectionContributions.Find(id);
            if (contributions == null)
            {
                return HttpNotFound();
            }
            return View(contributions);
        }

        //
        // POST: /Contributions/Edit/5

        [HttpPost]
        public ActionResult Edit(Contributions contributions)
        {
            if (ModelState.IsValid)
            {
                db.Entry(contributions).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(contributions);
        }

        //
        // GET: /Contributions/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Contributions contributions = db.ElectionContributions.Find(id);
            if (contributions == null)
            {
                return HttpNotFound();
            }
            return View(contributions);
        }

        //
        // POST: /Contributions/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Contributions contributions = db.ElectionContributions.Find(id);
            db.ElectionContributions.Remove(contributions);
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
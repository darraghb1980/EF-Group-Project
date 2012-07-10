using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemoApplication.Models;

namespace DemoApplication.Controllers
{
    public class CalculateController : Controller
    {
        private ExchangeDb db = new ExchangeDb();

        //
        // GET: /Calculate/

        public ActionResult Index()
        {
            return View(db.exchangeRates.ToList());
        }

        //
        // GET: /Calculate/Details/5

        public ActionResult Details(int id = 0)
        {
            ExchangeRate exchangerate = db.exchangeRates.Find(id);
            if (exchangerate == null)
            {
                return HttpNotFound();
            }
            return View(exchangerate);
        }

        //
        // GET: /Calculate/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Calculate/Create

        [HttpPost]
        public ActionResult Create(ExchangeRate exchangerate)
        {
            if (ModelState.IsValid)
            {
                db.exchangeRates.Add(exchangerate);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(exchangerate);
        }

        //
        // GET: /Calculate/Edit/5

        public ActionResult Edit(int id = 0)
        {
            ExchangeRate exchangerate = db.exchangeRates.Find(id);
            if (exchangerate == null)
            {
                return HttpNotFound();
            }
            return View(exchangerate);
        }

        //
        // POST: /Calculate/Edit/5

        [HttpPost]
        public ActionResult Edit(ExchangeRate exchangerate)
        {
            if (ModelState.IsValid)
            {
                db.Entry(exchangerate).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(exchangerate);
        }

        //
        // GET: /Calculate/Delete/5

        public ActionResult Delete(int id = 0)
        {
            ExchangeRate exchangerate = db.exchangeRates.Find(id);
            if (exchangerate == null)
            {
                return HttpNotFound();
            }
            return View(exchangerate);
        }

        //
        // POST: /Calculate/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            ExchangeRate exchangerate = db.exchangeRates.Find(id);
            db.exchangeRates.Remove(exchangerate);
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
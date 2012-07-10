using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemoApplication.Models;
using DemoApplication.dal;
using System.Net;
using System.Runtime.Serialization.Json;

namespace DemoApplication.Controllers
{
    public class HomeController : Controller
    {
        private ExchangeDb db = new ExchangeDb();

        //
        // GET: /Home/

        public ActionResult Index()
        {
            //db.Database.Delete();
           // ExchangeRateDAL dal = new ExchangeRateDAL();
            //next line re adrian's website
            makeRequest();

            return View(db.exchangeRates.ToList());
        }

        private Channel makeRequest()
        {
            String requestUrl = "www.ipic.tv/web/api/channels";
               try
        {
        HttpWebRequest request = WebRequest.Create(requestUrl) as HttpWebRequest;
        using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
         {
            if (response.StatusCode != HttpStatusCode.OK)
                throw new Exception(String.Format(
                "Server error (HTTP {0}: {1}).",
                response.StatusCode,
                response.StatusDescription));
            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(Channel));
            object objResponse = jsonSerializer.ReadObject(response.GetResponseStream());
            Channel jsonResponse = objResponse as Channel;
            return jsonResponse;
            }
       }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
        return null;
    }
        }

        //
        // GET: /Home/Details/5

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
        // GET: /Home/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Home/Create

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
        // POST: /Home/Calculate

        //[HttpPost, ActionName("Calculate")]
        public ActionResult Calculate(double amount)
        {
            if (ModelState.IsValid)
            {   
                return RedirectToAction("Index");
            }

            return View(amount);
        }

        //
        // GET: /Home/Edit/5

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
        // POST: /Home/Edit/5

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
        // GET: /Home/Delete/5

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
        // POST: /Home/Delete/5

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
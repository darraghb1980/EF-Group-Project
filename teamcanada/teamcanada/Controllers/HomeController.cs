/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using teamcanada.ingestion;
using teamcanada.Models;
using teamcanada.dal;
using System.Data.Entity;

namespace teamcanada.Controllers
{
    public class HomeController : Controller
    {
        // create reference to dal (methods you can run on the database)
        public csvParseDAL torontoDAL = new csvParseDAL();

        //create reference to database
        public torontoDB torontoDB = new torontoDB();

        public ActionResult Index()
        {
           ViewBag.Message = "Welcome to Team Canada!.";

          // return View(torontoDB.ElectionResults.ToList());

           return View();
        }
            
        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";



          return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
*/
	using System;
	using System.Web;
	using teamcanada.Models;
using System.Web.Mvc;
	
	namespace teamcanada.Controllers {
	    [HandleError]
	    public class HomeController : Controller {
	        IContributionRepository _repository;
	        public HomeController() : this(new EF_ContributionRepository()) { }
	        public HomeController(IContributionRepository repository) {
	            _repository = repository;
	        }
	       /* public ViewResult Index() {
	            throw new NotImplementedException();
	        }*/
	    	public ViewResult Index() {
	            return View("Index", _repository.GetAllContributions());
	        }


            public ViewResult Create(Contributions model)
            {
                throw new NotImplementedException();
            }
        }
	}

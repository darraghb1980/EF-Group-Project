using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using teamcanada.dal;
using teamcanada.ingestion;
using teamcanada.Models;

namespace teamcanada.Controllers
{
    public class HomeController : Controller
    {

        //create reference to database
        public torontoDB torontoDB = new torontoDB();

        public ActionResult Index()
        {
           ViewBag.Message = "Welcome to Team Canada!.";

           return View();
        }
            
        public ActionResult ViewResults()
        {
            ViewBag.Message = "View a list of all Election Results.";

          return View();
        }

        public ActionResult ViewContributions()
        {
            ViewBag.Message = "View a list of all Election Contributions.";

            return View();
        }

    }
}

/*
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
	       public ViewResult Index() {
	            throw new NotImplementedException();
	        }
	    	public ViewResult Index() {
	            return View("Index", _repository.GetAllContributions());
	        }


            public ViewResult Create(Contributions model)
            {
                throw new NotImplementedException();
            }
        }
	}

*/
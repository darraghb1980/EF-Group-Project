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
    [HandleError]
    public class HomeController2 : Controller
    {
        IContributionRepository _repository;
        public HomeController2() : this(new EF_ContributionRepository()) { }
        public HomeController2(IContributionRepository repository)
        {
            _repository = repository;
        }
        /* public ViewResult Index()
         {
             throw new NotImplementedException();
         }*/
        public ViewResult Index()
        {
            return View("Index", _repository.GetAllContributions());
        }


        public ViewResult Create(Contributions model)
        {
            return View("Index", _repository.GetAllContributions());
        }
    }

}
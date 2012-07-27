using System;
using System.Text.RegularExpressions;
using System.Web;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using teamcanada.Controllers;
using teamcanada.Models;
using teamcanada.Tests.Models;
using System.Data.Entity;
using System.Data;
using System.Linq;
using System.Web.Routing;
using System.Security.Principal;
using System.Web.Mvc;
using System.Collections.Generic;



namespace teamcanada.Tests.Controllers
{
    [TestClass]
    public class HomeController2Test
    {
        //removing this as it  is already below.this is extra code from des.
        /*
        Contributions GetContribution()
        {
        return GetContribution();
        }*/

        Contributions GetContribution(string type)
        {
            return new Contributions
            {
                ElectionType = type
            };
        }

        //tmp remove. needs sorting. council variable problem
        Contributions GetContributionID(string council, int year)
        {
            return GetContributionNamed(council, 2006);
        }

        Contributions GetContributionNamed(string type, int year)
        {
            return new Contributions
            {
                ElectionType = type,
                ElectionYear = year,
            };
        }

       
        Contributions GetContribution()
        {
            return GetContribution("Council", 2020, "Second", "first", "123 main st", "abc123", 999,
                123,
                "cash", "individual", "John", "Doe");
        }

        Contributions GetContribution(string cncl, int x, string cLName, string cFName,
            string conAddress, string conPstCde, int wrdNm, float y, string cnTDesc, string crTDesc,
            string cnFName, string cnLName)
        {
            return new Contributions
            {
                //id = id,
                ElectionType = cncl,
                ElectionYear = 2020,
                ContributorLastName = cLName,
                ContributorFirstName = cFName,
                ContributorAddress = conAddress,
                ContributorPostCode = conPstCde,
                WardNum = wrdNm,
                Amount = y,
                ContributionTypeDesc = cnTDesc,
                ContributorTypeDesc = crTDesc,
                CandidateFirstName = cnFName,
                CandidateLastName = cnLName,
                
            };
        }

        private static HomeController2 GetHomeController(IContributionRepository repository)
        {
            HomeController2 controller = new HomeController2(repository);

            controller.ControllerContext = new ControllerContext()
            {
                Controller = controller,
                RequestContext = new RequestContext(new MockHttpContext(), new RouteData())
            };
            return controller;
        }


        private class MockHttpContext : HttpContextBase
        {
            private readonly IPrincipal _user = new GenericPrincipal(
                     new GenericIdentity("someUser"), null /* roles */);

            public override IPrincipal User
            {
                get
                {
                    return _user;
                }
                set
                {
                    base.User = value;
                }
            }
        }

        //page 7 of DH
        [TestMethod]
        public void Index_Get_AsksForIndexView()
        {
            // Arrange
            var controller = GetHomeController(new InMemoryContributionRepository());
            // Act
            ViewResult result = controller.Index();
            // Assert
            Assert.AreEqual("Index", result.ViewName);
        }

        //removing to allow tests to pass
        //page 8
        [TestMethod]
        public void Index_Get_RetrievesAllContributionsFromRepository()
        {

            // Arrange
            Contributions Contribution1 = GetContributionNamed("Council", 2003);
            Contributions Contribution2 = GetContributionNamed("Council", 2004);

            InMemoryContributionRepository repository = new InMemoryContributionRepository();
            repository.Add(Contribution1);
            repository.Add(Contribution2);
            var controller = GetHomeController(repository);

            // Act
            var result = controller.Index();

            // Assert
            var model = (IEnumerable<Contributions>)result.ViewData.Model;
            CollectionAssert.Contains(model.ToList(), Contribution1);
            CollectionAssert.Contains(model.ToList(), Contribution2);
            // confirm model has 2 values added
            Assert.AreEqual(2, model.ToList().Count());


        }
        [TestMethod]
        public void Index_Get_RetrievesAllContributionsFromRepository2()
        {

            // Arrange
            Contributions Contribution1 = GetContributionNamed("Council", 2003);
            Contributions Contribution2 = GetContributionNamed("Council", 2004);
            Contributions Contribution3 = GetContributionNamed("Council", 2009);
            InMemoryContributionRepository repository = new InMemoryContributionRepository();
            repository.Add(Contribution1);
            repository.Add(Contribution2);
            var controller = GetHomeController(repository);

            // Act
            var result = controller.Index();

            // Assert
            var model = (IEnumerable<Contributions>)result.ViewData.Model;
            CollectionAssert.Contains(model.ToList(), Contribution1);
            CollectionAssert.Contains(model.ToList(), Contribution2);
            //check if contribution 3 has been added, which it hasn't.should fail
            CollectionAssert.Contains(model.ToList(), Contribution3);
            //check if contribution 1 has two values


        }


             

    }



}

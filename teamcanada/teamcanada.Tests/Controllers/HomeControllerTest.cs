﻿using System;
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
	    public class HomeControllerTest {
	        
	        Contributions GetContribution() {
	            return GetContribution("Council", 2020, "Second","first","123 main st","abc123",999,
                    123,
                    "cash","individual","John","Doe");
	        }
	
	        Contributions GetContribution(string cncl, int x, string cLName, string cFName, 
                string conAddress, string conPstCde, int wrdNm, float y, string cnTDesc, string crTDesc,
                string cnFName, string cnLName) {
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
                    ContributionTypeDesc =cnTDesc,
                    ContributorTypeDesc = crTDesc,
                    CandidateFirstName = cnFName,
                    CandidateLastName = cnLName,
	               /* LastName = lName,
	                Phone = "710-555-0173",
	                Email = "janet1@adventure-works.com"*/
	            };
	        }
	
	        private static HomeController GetHomeController(IContributionRepository repository) {
	            HomeController controller = new HomeController(repository);
	
	            controller.ControllerContext = new ControllerContext()
	            {
	                Controller = controller,
	                RequestContext = new RequestContext(new MockHttpContext(), new RouteData())
	            };
	            return controller;
	        }
	
	
	        private class MockHttpContext : HttpContextBase {
	            private readonly IPrincipal _user = new GenericPrincipal(
	                     new GenericIdentity("someUser"), null /* roles */);
	
	            public override IPrincipal User {
	                get {
	                    return _user;
	                }
	                set {
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
            
            //page 8
            [TestMethod]
            public void Index_Get_RetrievesAllContributionsFromRepository()
            {
                // Arrange
                Contributions Contribution1 = GetContributionNamed("Council", 2003,"Breathnach","Darragh","48 The willow",
                    "www222",99,999,"Cash","Individual","Fintan","Costello");
                Contributions Contribution2 = GetContributionNamed("Council", 2004, "McCormack", "Alan", "Sandymount",
                    "www111", 98, 888, "Cash", "Company", "Eoin", "O Loideain");
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
            }

            private Contributions GetContributionNamed(string p, int p_2, string p_3, string p_4, string p_5, string p_6, int p_7, int p_8, string p_9, string p_10, string p_11, string p_12)
            {
                throw new System.NotImplementedException();
            }

            //To add a test for creating a Contribution
            [TestMethod]
            public void Create_Post_ReturnsViewIfModelStateIsNotValid()
            {
                // Arrange
                HomeController controller = GetHomeController(new InMemoryContributionRepository());
                // Simply executing a method during a unit test does just that - executes a method, and no more. 
                // The MVC pipeline doesn't run, so binding and validation don't run.
                controller.ModelState.AddModelError("", "mock error message");
                
                //******************this part isn't working
                //******************something to do with the arguments.were initially empty
                Contributions model = GetContributionNamed("Council", " ");
                // Act
                var result = (ViewResult)controller.Create(model);

                // Assert
                Assert.AreEqual("Create", result.ViewName);
            }

            private Contributions GetContributionNamed(string p, string p_2)
            {
                throw new System.NotImplementedException();
            } 

            //page 9
            [TestMethod]
            public void Create_Post_PutsValidContributionIntoRepository()
            {
                // Arrange
                InMemoryContributionRepository repository = new InMemoryContributionRepository();
                HomeController controller = GetHomeController(repository);
                //Contributions Contribution = GetContributionID_1();
                Contributions Contribution = GetContribution();

                // Act
                controller.Create(Contribution);

                // Assert
                IEnumerable<Contributions> Contributions = repository.GetAllContributions();
                Assert.IsTrue(Contributions.Contains(Contribution));
            } 


            //page 9
            [TestMethod]
            public void Create_Post_ReturnsViewIfRepositoryThrowsException()
            {
                // Arrange
                InMemoryContributionRepository repository = new InMemoryContributionRepository();
                Exception exception = new Exception();
                repository.ExceptionToThrow = exception;
                HomeController controller = GetHomeController(repository);
                //next line, i've removed "ID_1" from end of GetContribution
                Contributions model = GetContribution();

                // Act
                var result = (ViewResult)controller.Create(model);

                // Assert
                Assert.AreEqual("Create", result.ViewName);
                ModelState modelState = result.ViewData.ModelState[""];
                Assert.IsNotNull(modelState);
                Assert.IsTrue(modelState.Errors.Any());
                Assert.AreEqual(exception, modelState.Errors[0].Exception);
            } 


	    }

           

	}

	using System.Web;
	using Microsoft.VisualStudio.TestTools.UnitTesting;
	using teamcanada.Controllers;

    using teamcanada.Models;
    using teamcanada.Tests.Models;
	using System.Web;
	using System.Web.Routing;
	using System.Security.Principal;

namespace teamcanada.Tests.Controllers
{
	    [TestClass]
	    public class HomeControllerTest {
	        
	        Contributions GetContribution() {
	            return GetContribution(1, "Janet", "Gates");
	        }
	
	        Contributions GetContribution(int id, string fName, string lName) {
	            return new Contributions
	            {
	                Id = id,
	                FirstName = fName,
	                LastName = lName,
	                Phone = "710-555-0173",
	                Email = "janet1@adventure-works.com"
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
	    }
	}

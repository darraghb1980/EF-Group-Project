using teamcanada.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;
using System.Data.Entity;

namespace teamcanada.Tests
{
    
    
    /// <summary>
    ///This is a test class for torontoDbTest and is intended
    ///to contain all torontoDbTest Unit Tests
    ///</summary>
    [TestClass()]
    public class torontoDbTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for torontoDb Constructor
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\DB\\Documents\\GitHub\\EF-Group-Project\\teamcanada\\teamcanada", "/")]
        [UrlToTest("http://localhost:53507/")]
        public void torontoDbConstructorTest()
        {
            torontoDb target = new torontoDb();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for contributions
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\DB\\Documents\\GitHub\\EF-Group-Project\\teamcanada\\teamcanada", "/")]
        [UrlToTest("http://localhost:53507/")]
        public void contributionsTest()
        {
            torontoDb target = new torontoDb(); // TODO: Initialize to an appropriate value
            DbSet<Contributions> expected = null; // TODO: Initialize to an appropriate value
            DbSet<Contributions> actual;
            target.contributions = expected;
            actual = target.contributions;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for results
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\DB\\Documents\\GitHub\\EF-Group-Project\\teamcanada\\teamcanada", "/")]
        [UrlToTest("http://localhost:53507/")]
        public void resultsTest()
        {
            torontoDb target = new torontoDb(); // TODO: Initialize to an appropriate value
            DbSet<Results> expected = null; // TODO: Initialize to an appropriate value
            DbSet<Results> actual;
            target.results = expected;
            actual = target.results;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}

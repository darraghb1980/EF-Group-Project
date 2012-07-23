using teamcanada.ingestion;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;
using teamcanada.Models;
using System.Collections.Generic;

namespace teamcanada.Tests
{
    
    
    /// <summary>
    ///This is a test class for ResultsLoadCSVTest and is intended
    ///to contain all ResultsLoadCSVTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ResultsLoadCSVTest
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
        ///A test for loadResults
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        /*[TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\DB\\Documents\\GitHub\\EF-Group-Project\\darraghTestWork\\teamcanada\\teamcanada", "/")]
        [UrlToTest("http://localhost:53507/")]
        public void loadResultsTest()
        {
            ResultsLoadCSV target = new ResultsLoadCSV(); // TODO: Initialize to an appropriate value
            List<Results> expected = null; // TODO: Initialize to an appropriate value
            List<Results> actual;
            actual = target.loadResults();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }*/

        /// <summary>
        ///A test for loadContributions
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        /*
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\DB\\Documents\\GitHub\\EF-Group-Project\\darraghTestWork\\teamcanada\\teamcanada", "/")]
        [UrlToTest("http://localhost:53507/")]
        public void loadContributionsTest()
        {
            ResultsLoadCSV target = new ResultsLoadCSV(); // TODO: Initialize to an appropriate value
            List<Contributions> expected = null; // TODO: Initialize to an appropriate value
            List<Contributions> actual;
            actual = target.loadContributions();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }*/

        /// <summary>
        ///A test for ResultsLoadCSV Constructor
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        /*[TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\DB\\Documents\\GitHub\\EF-Group-Project\\darraghTestWork\\teamcanada\\teamcanada", "/")]
        [UrlToTest("http://localhost:53507/")]
        public void ResultsLoadCSVConstructorTest()
        {
            ResultsLoadCSV target = new ResultsLoadCSV();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }*/
    }
}

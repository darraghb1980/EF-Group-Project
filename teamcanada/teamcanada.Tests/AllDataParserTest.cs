using teamcanada.ingestion;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;
using teamcanada.Models;
using System.Collections.Generic;
using System.IO;

namespace teamcanada.Tests
{
    
    
    /// <summary>
    ///This is a test class for AllDataParserTest and is intended
    ///to contain all AllDataParserTest Unit Tests
    ///</summary>
    [TestClass()]
    public class AllDataParserTest
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


        internal virtual AllDataParser CreateAllDataParser()
        {
            // TODO: Instantiate an appropriate concrete class.
            AllDataParser target = null;
            return target;
        }

        /// <summary>
        ///A test for parseContributions
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\eoiny\\Documents\\GitHub\\EF-Group-Project\\teamcanada\\teamcanada", "/")]
        [UrlToTest("http://localhost:53507/")]
        public void parseContributionsTest()
        {
            AllDataParser target = CreateAllDataParser(); // TODO: Initialize to an appropriate value
            List<Contributions> expected = null; // TODO: Initialize to an appropriate value
            List<Contributions> actual;
            actual = target.parseContributions();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for parseResults
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\eoiny\\Documents\\GitHub\\EF-Group-Project\\teamcanada\\teamcanada", "/")]
        [UrlToTest("http://localhost:53507/")]
        public void parseResultsTest()
        {
            AllDataParser target = CreateAllDataParser(); // TODO: Initialize to an appropriate value
            List<Results> expected = null; // TODO: Initialize to an appropriate value
            List<Results> actual;
            actual = target.parseResults();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for setStreamSource
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\eoiny\\Documents\\GitHub\\EF-Group-Project\\teamcanada\\teamcanada", "/")]
        [UrlToTest("http://localhost:53507/")]
        public void setStreamSourceTest()
        {
            AllDataParser target = CreateAllDataParser(); // TODO: Initialize to an appropriate value
            StreamReader reader = null; // TODO: Initialize to an appropriate value
            target.setStreamSource(reader);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for supportsType
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\eoiny\\Documents\\GitHub\\EF-Group-Project\\teamcanada\\teamcanada", "/")]
        [UrlToTest("http://localhost:53507/")]
        public void supportsTypeTest()
        {
            AllDataParser target = CreateAllDataParser(); // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.supportsType(format);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}

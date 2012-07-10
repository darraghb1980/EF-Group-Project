using DemoApplication.ingestion;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;
using DemoApplication.Models;
using System.Collections.Generic;
using System.IO;

namespace DemoApplication.Tests
{
    
    
    /// <summary>
    ///This is a test class for CSVParserTest and is intended
    ///to contain all CSVParserTest Unit Tests
    ///</summary>
    [TestClass()]
    public class CSVParserTest
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
        ///A test for CSVParser Constructor
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\lhogan\\Documents\\Visual Studio 2010\\Projects\\DemoApplication\\DemoApplication", "/")]
        [UrlToTest("http://localhost:56662/")]
        public void CSVParserConstructorTest()
        {
            CSVParser target = new CSVParser();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for DemoApplication.ingestion.IDataParser.parseExchangeRates
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        public void parseExchangeRatesTest()
        {
            StreamReader reader = new StreamReader("c:\\temp\\rates.csv", true);

            IDataParser target = new CSVParser();
            target.setStreamSource(reader);
            ExchangeRate r = new ExchangeRate();
            r.fromCurrency="USD";
            r.toCurrency="EUR";
            r.rate=1.33;

            List<ExchangeRate> expected = new List<ExchangeRate>();
            expected.Add(r);

            List<ExchangeRate> actual;
            actual = target.parseExchangeRates();
            Assert.AreEqual(expected.Count, actual.Count);
            
            ExchangeRate rate = actual.Find(item => item.fromCurrency == "USD");
            

            Assert.IsNotNull(rate);

            // As an exercise for the reader, make sure that the rate object is correctly populated
        }

        /// <summary>
        ///A test for DemoApplication.ingestion.IDataParser.setStreamSource
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\lhogan\\Documents\\Visual Studio 2010\\Projects\\DemoApplication\\DemoApplication", "/")]
        [UrlToTest("http://localhost:56662/")]
        [DeploymentItem("DemoApplication.dll")]
        public void setStreamSourceTest()
        {
            IDataParser target = new CSVParser(); // TODO: Initialize to an appropriate value
            StreamReader reader = null; // TODO: Initialize to an appropriate value
            target.setStreamSource(reader);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for DemoApplication.ingestion.IDataParser.supportsType
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        public void supportsTypeTest()
        {
            IDataParser target = new CSVParser(); 
            
            string format = null;
            bool expected = false;
            bool actual;
            actual = target.supportsType(format);
            Assert.AreEqual(expected, actual);
        }
    }
}

using teamcanada.ingestion;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;
using System.IO;
using teamcanada.Models;
using System.Collections.Generic;

namespace teamcanada.Tests
{


    /// <summary>
    ///This is a test class for ResultsParseTest and is intended
    ///to contain all ResultsParseTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ResultsParseTest
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
        ///A test for teamcanada.ingestion.AllDataParser.supportsType
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        // [HostType("ASP.NET")]
        //[AspNetDevelopmentServerHost("C:\\Users\\DB\\Documents\\GitHub\\EF-Group-Project\\darraghTestWork\\teamcanada\\teamcanada", "/")]
        //[UrlToTest("http://localhost:53507/")]
        //[DeploymentItem("teamcanada.dll")]
        public void supportsTypeTest()
        {
            AllDataParser target = new DataParse(); // TODO: Initialize to an appropriate value
            string format = null; // TODO: Initialize to an appropriate value
            bool expected = false; ; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.supportsType(format);
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }





        [TestMethod()]
        public void nullCSV()
        {
            AllDataParser target = new DataParse(); // TODO: Initialize to an appropriate value
            string format = null; // TODO: Initialize to an appropriate value
            bool expected = false; ; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.supportsType(format);
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void notCSV()
        {
            AllDataParser target = new DataParse(); // TODO: Initialize to an appropriate value
            string format = "notcsv"; // TODO: Initialize to an appropriate value
            bool expected = false; ; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.supportsType(format);
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}

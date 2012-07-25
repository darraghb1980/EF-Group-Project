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
    ///This is a test class for DataParseTest and is intended
    ///to contain all DataParseTest Unit Tests
    ///</summary>
    [TestClass()]
    public class DataParseTest
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
        ///A test for DataParse Constructor
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\DB\\Documents\\GitHub\\EF-Group-Project\\teamcanada\\teamcanada", "/")]
        [UrlToTest("http://localhost:53507/")]
        public void DataParseConstructorTest()
        {
            DataParse target = new DataParse();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for teamcanada.ingestion.AllDataParser.parseContributions
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\DB\\Documents\\GitHub\\EF-Group-Project\\teamcanada\\teamcanada", "/")]
        [UrlToTest("http://localhost:53507/")]
        [DeploymentItem("teamcanada.dll")]
        public void parseContributionsTest()
        {
            AllDataParser target = new DataParse(); // TODO: Initialize to an appropriate value
            List<Contributions> expected = null; // TODO: Initialize to an appropriate value
            List<Contributions> actual;
            actual = target.parseContributions();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for teamcanada.ingestion.AllDataParser.parseResults
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\DB\\Documents\\GitHub\\EF-Group-Project\\teamcanada\\teamcanada", "/")]
        [UrlToTest("http://localhost:53507/")]
        [DeploymentItem("teamcanada.dll")]
        public void parseResultsTest()
        {
            AllDataParser target = new DataParse(); // TODO: Initialize to an appropriate value
            List<Results> expected = null; // TODO: Initialize to an appropriate value
            List<Results> actual;
            actual = target.parseResults();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for teamcanada.ingestion.AllDataParser.setStreamSource
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\DB\\Documents\\GitHub\\EF-Group-Project\\teamcanada\\teamcanada", "/")]
        [UrlToTest("http://localhost:53507/")]
        [DeploymentItem("teamcanada.dll")]
        public void setStreamSourceTest()
        {
            AllDataParser target = new DataParse(); // TODO: Initialize to an appropriate value
            StreamReader reader = null; // TODO: Initialize to an appropriate value
            target.setStreamSource(reader);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for teamcanada.ingestion.AllDataParser.supportsType
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\DB\\Documents\\GitHub\\EF-Group-Project\\teamcanada\\teamcanada", "/")]
        [UrlToTest("http://localhost:53507/")]
        [DeploymentItem("teamcanada.dll")]
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

        //StreamReader
        [TestMethod()]
        public void parsecsvTest()
        {
            StreamReader reader = new StreamReader("C:\\Users\\DB\\Documents\\NCI\\Enterprise Frameworks\\Project\\testContributions.csv", true);

            AllDataParser target = new DataParse();
            target.setStreamSource(reader);
            Contributions r = new Contributions();
            r.ElectionType = "Council";
            r.ElectionYear = 2006;
            r.ContributorLastName = "Aloi";
            r.ContributorFirstName = "77";
            r.ContributorAddress = "asdhfbkaef";
            r.ContributorPostCode = "efeae";
            r.WardNum = 3;
            r.Amount = 200;
            r.ContributionTypeDesc = "Cash";
            r.ContributorTypeDesc = "individ";
            r.CandidateFirstName = "joe";
            r.CandidateLastName = "walsh";

            //r.rate = 1.33;

            List<Contributions> expected = new List<Contributions>();
            expected.Add(r);

            List<Contributions> actual;
            actual = target.parseContributions();
            //Assert.AreEqual(expected.Count, actual.Count);

            Contributions ElectionType = actual.Find(item => item.ElectionType == "Council");


            Assert.IsNotNull(ElectionType);

            // As an exercise for the reader, make sure that the rate object is correctly populated
        }
    }
}

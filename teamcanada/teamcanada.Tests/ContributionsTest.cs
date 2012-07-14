using teamcanada.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;

namespace teamcanada.Tests
{
    
    
    /// <summary>
    ///This is a test class for ContributionsTest and is intended
    ///to contain all ContributionsTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ContributionsTest
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
        ///A test for Contributions Constructor
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\DB\\Documents\\GitHub\\EF-Group-Project\\teamcanada\\teamcanada", "/")]
        [UrlToTest("http://localhost:53507/")]
        public void ContributionsConstructorTest()
        {
            Contributions target = new Contributions();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Contributions Constructor
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\DB\\Documents\\GitHub\\EF-Group-Project\\teamcanada\\teamcanada", "/")]
        [UrlToTest("http://localhost:53507/")]
        public void ContributionsConstructorTest1()
        {
            string _ElectionType = string.Empty; // TODO: Initialize to an appropriate value
            int _ElectionYear = 0; // TODO: Initialize to an appropriate value
            string _ContributorFirstName = string.Empty; // TODO: Initialize to an appropriate value
            string _ContributorLastName = string.Empty; // TODO: Initialize to an appropriate value
            string _ContributorPostCode = string.Empty; // TODO: Initialize to an appropriate value
            string _ContributorAddress = string.Empty; // TODO: Initialize to an appropriate value
            int _WardNum = 0; // TODO: Initialize to an appropriate value
            float _Amount = 0F; // TODO: Initialize to an appropriate value
            string _ContributionType = string.Empty; // TODO: Initialize to an appropriate value
            string _ContributionTypeDesc = string.Empty; // TODO: Initialize to an appropriate value
            string _ContributorType = string.Empty; // TODO: Initialize to an appropriate value
            string _ContributorTypeDesc = string.Empty; // TODO: Initialize to an appropriate value
            string _CandidateFirstName = string.Empty; // TODO: Initialize to an appropriate value
            string _CandidateLastName = string.Empty; // TODO: Initialize to an appropriate value
            Contributions target = new Contributions(_ElectionType, _ElectionYear, _ContributorFirstName, _ContributorLastName, _ContributorPostCode, _ContributorAddress, _WardNum, _Amount, _ContributionType, _ContributionTypeDesc, _ContributorType, _ContributorTypeDesc, _CandidateFirstName, _CandidateLastName);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Amount
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\DB\\Documents\\GitHub\\EF-Group-Project\\teamcanada\\teamcanada", "/")]
        [UrlToTest("http://localhost:53507/")]
        public void AmountTest()
        {
            Contributions target = new Contributions(); // TODO: Initialize to an appropriate value
            float expected = 0F; // TODO: Initialize to an appropriate value
            float actual;
            target.Amount = expected;
            actual = target.Amount;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for CandidateFirstName
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\DB\\Documents\\GitHub\\EF-Group-Project\\teamcanada\\teamcanada", "/")]
        [UrlToTest("http://localhost:53507/")]
        public void CandidateFirstNameTest()
        {
            Contributions target = new Contributions(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.CandidateFirstName = expected;
            actual = target.CandidateFirstName;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for CandidateLastName
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\DB\\Documents\\GitHub\\EF-Group-Project\\teamcanada\\teamcanada", "/")]
        [UrlToTest("http://localhost:53507/")]
        public void CandidateLastNameTest()
        {
            Contributions target = new Contributions(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.CandidateLastName = expected;
            actual = target.CandidateLastName;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ContributionType
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\DB\\Documents\\GitHub\\EF-Group-Project\\teamcanada\\teamcanada", "/")]
        [UrlToTest("http://localhost:53507/")]
        public void ContributionTypeTest()
        {
            Contributions target = new Contributions(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.ContributionType = expected;
            actual = target.ContributionType;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ContributionTypeDesc
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\DB\\Documents\\GitHub\\EF-Group-Project\\teamcanada\\teamcanada", "/")]
        [UrlToTest("http://localhost:53507/")]
        public void ContributionTypeDescTest()
        {
            Contributions target = new Contributions(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.ContributorTypeDesc = expected;
            actual = target.ContributorTypeDesc;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ContributorAddress
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\DB\\Documents\\GitHub\\EF-Group-Project\\teamcanada\\teamcanada", "/")]
        [UrlToTest("http://localhost:53507/")]
        public void ContributorAddressTest()
        {
            Contributions target = new Contributions(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.ContributorAddress = expected;
            actual = target.ContributorAddress;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ContributorFirstName
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\DB\\Documents\\GitHub\\EF-Group-Project\\teamcanada\\teamcanada", "/")]
        [UrlToTest("http://localhost:53507/")]
        public void ContributorFirstNameTest()
        {
            Contributions target = new Contributions(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.ContributorFirstName = expected;
            actual = target.ContributorFirstName;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ContributorLastName
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\DB\\Documents\\GitHub\\EF-Group-Project\\teamcanada\\teamcanada", "/")]
        [UrlToTest("http://localhost:53507/")]
        public void ContributorLastNameTest()
        {
            Contributions target = new Contributions(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.ContributorLastName = expected;
            actual = target.ContributorLastName;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ContributorPostCode
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\DB\\Documents\\GitHub\\EF-Group-Project\\teamcanada\\teamcanada", "/")]
        [UrlToTest("http://localhost:53507/")]
        public void ContributorPostCodeTest()
        {
            Contributions target = new Contributions(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.ContributorPostCode = expected;
            actual = target.ContributorPostCode;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ContributorType
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\DB\\Documents\\GitHub\\EF-Group-Project\\teamcanada\\teamcanada", "/")]
        [UrlToTest("http://localhost:53507/")]
        public void ContributorTypeTest()
        {
            Contributions target = new Contributions(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.ContributorType = expected;
            actual = target.ContributorType;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ContributorTypeDesc
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\DB\\Documents\\GitHub\\EF-Group-Project\\teamcanada\\teamcanada", "/")]
        [UrlToTest("http://localhost:53507/")]
        public void ContributorTypeDescTest()
        {
            Contributions target = new Contributions(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.ContributorTypeDesc = expected;
            actual = target.ContributorTypeDesc;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ElectionType
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\DB\\Documents\\GitHub\\EF-Group-Project\\teamcanada\\teamcanada", "/")]
        [UrlToTest("http://localhost:53507/")]
        public void ElectionTypeTest()
        {
            Contributions target = new Contributions(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.ElectionType = expected;
            actual = target.ElectionType;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ElectionYear
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\DB\\Documents\\GitHub\\EF-Group-Project\\teamcanada\\teamcanada", "/")]
        [UrlToTest("http://localhost:53507/")]
        public void ElectionYearTest()
        {
            Contributions target = new Contributions(); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            target.ElectionYear = expected;
            actual = target.ElectionYear;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for WardNum
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\DB\\Documents\\GitHub\\EF-Group-Project\\teamcanada\\teamcanada", "/")]
        [UrlToTest("http://localhost:53507/")]
        public void WardNumTest()
        {
            Contributions target = new Contributions(); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            target.WardNum = expected;
            actual = target.WardNum;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for id
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\DB\\Documents\\GitHub\\EF-Group-Project\\teamcanada\\teamcanada", "/")]
        [UrlToTest("http://localhost:53507/")]
        public void idTest()
        {
            Contributions target = new Contributions(); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            target.id = expected;
            actual = target.id;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}

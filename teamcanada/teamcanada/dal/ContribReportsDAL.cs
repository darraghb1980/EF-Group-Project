using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using teamcanada.Models;
using teamcanada.Models.ui;

namespace teamcanada.dal
{

    // this outputs all records with the listed column headings
    // we could create a method for each report, but its better to try to build the report here based on the form input
    // from the user in the view, to allow for dynamically created reports

    // report 1 from contributions

    public class ContribReportsDAL
    {

        public static IEnumerable<ReportsUI> GetReportData()                                 // Method to select data from the database
        {
            using (torontoDB db = new torontoDB())
            {

                var reportData = from c in db.ElectionContributions.AsEnumerable()
                
                                 // filter the report. This is hardcoded, but we should be taking these values
                                 // from select boxes on the view
                                 
                                 where c.ElectionType == ("Mayoral") && c.ElectionYear == (Convert.ToDouble(2010)) && c.WardNum == 2

                                  select new ReportsUI                                       // Create new ReportUI object and assign it the values selected from the database
                                  {
                                      ElectionType = c.ElectionType,
                                      ElectionYear = c.ElectionYear,
                                      WardNum = c.WardNum,
                                      ContributorFirstName = c.ContributorFirstName,
                                      ContributorLastName = c.ContributorLastName,
                                      CandidateLastName = c.CandidateLastName,
                                      ContributionTypeDesc = c.ContributionTypeDesc
                                  };

                return reportData.ToArray();                                                // ToArray() method is needed to prevent DbContext error

            }

        }

// report 2 from contributions

        public static IEnumerable<ReportsUI> GetReportData2()                                 // Method to select data from the database
        {
            using (torontoDB db = new torontoDB())
            {

                var reportData2 = from c in db.ElectionContributions.AsEnumerable()

                                 // filter the report by Mayoral/2010/ward number 2. This is hardcoded, but should be taking these values
                                 // from select boxes on the view

                                 where c.ElectionType == ("Council") && c.ElectionYear == (Convert.ToDouble(2006)) && c.Amount <= 500


                                 select new ReportsUI                                       // Create new ReportUI object and assign it the values selected from the database
                                 {
                                     ElectionType = c.ElectionType,
                                     ElectionYear = c.ElectionYear,
                                     CandidateFirstName = c.CandidateFirstName,
                                     CandidateLastName = c.CandidateLastName,
                                     ContributionTypeDesc = c.ContributionTypeDesc,
                                     WardNum = c.WardNum,
                                     Amount = c.Amount

                                 };

                return reportData2.ToArray();                                                // ToArray() method is needed to prevent DbContext error

            }

        }

    }
}
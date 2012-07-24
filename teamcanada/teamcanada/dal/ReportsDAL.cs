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

    public class ReportsDAL
    {

        public static IEnumerable<ReportsUI> GetReportData()                                 // Method to select Report 5 data from the database
        {
            using (torontoDB db = new torontoDB())
            {

                var reportData = from c in db.ElectionContributions.AsEnumerable()
                                  select new ReportsUI                                       // Create new ReportUI object and assign it the values selected from the database
                                  {
                                      ElectionType = c.ElectionType,
                                      ElectionYear = c.ElectionYear,
                                      CandidateFirstName = c.CandidateFirstName,
                                      CandidateLastName = c.CandidateLastName,
                                      ContributionTypeDesc = c.ContributionTypeDesc
                                  };

                return reportData.ToArray();                                                // ToArray() method is needed to prevent DbContext error

            }

        }

    }
}
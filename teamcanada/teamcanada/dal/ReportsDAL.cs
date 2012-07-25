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
                
                                 // filter the report by Mayoral/2010/ward number 2. This is hardcoded, but should be taking these values
                                 // from select boxes on the view
                                 
                                 where c.ElectionType == ("Mayoral") && c.ElectionYear == (Convert.ToDouble(2010)) && c.WardNum == 2

     
                                  select new ReportsUI                                       // Create new ReportUI object and assign it the values selected from the database
                                  {
                                      ElectionType = c.ElectionType,
                                      ElectionYear = c.ElectionYear,
                                      CandidateFirstName = c.CandidateFirstName,
                                      CandidateLastName = c.CandidateLastName,
                                      ContributionTypeDesc = c.ContributionTypeDesc,
                                      WardNum = c.WardNum                    

                                  };

                return reportData.ToArray();                                                // ToArray() method is needed to prevent DbContext error

            }

        }

    }
}
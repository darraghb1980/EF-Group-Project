using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using teamcanada.Models;
using teamcanada.Models.ui;

namespace teamcanada.dal
{
    public class contributionsDAL
    {
        //protected torontoDB db = new torontoDB();

        public static IEnumerable<Report5UI> GetReportData()                                 // Method to select Report 5 data from the database
        {
            using (torontoDB db = new torontoDB())
            {

                var report5Data = from c in db.ElectionContributions.AsEnumerable()
                                  select new Report5UI                                       // Create new Report5UI object and assign it the values selected from the database
                                  {
                                      ElectionType = c.ElectionType,
                                      ElectionYear = c.ElectionYear,
                                      CandidateFirstName = c.CandidateFirstName,
                                      CandidateLastName = c.CandidateLastName,
                                      ContributionTypeDesc = c.ContributionTypeDesc
                                  };

                return report5Data.ToArray();                                                // ToArray() method is needed to prevent DbContext error

            }

        }

    }
}
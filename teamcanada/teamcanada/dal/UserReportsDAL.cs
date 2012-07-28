using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using teamcanada.Models;
using teamcanada.Models.ui;

namespace teamcanada.dal
{
    public class UserReportsDAL
    {
        public static IEnumerable<ReportsUI> GetReportData(string ElectionType, int ElectionYear, int WardNum, String CandidateLastName, String ContributionTypeDesc)                                 // Method to select data from the database
        {
            using (torontoDB db = new torontoDB())
            {

                var reportData = from c in db.ElectionContributions.AsEnumerable()


                                 where c.ElectionType == (ElectionType) && c.ElectionYear == (Convert.ToDouble(ElectionYear)) && c.WardNum == (Convert.ToDouble(WardNum)) && c.CandidateLastName == CandidateLastName && c.ContributionTypeDesc == (ContributionTypeDesc)

                                 select new ReportsUI                                       // Create new ReportUI object and assign it the values selected from the database
                                 {
                                     ElectionType = c.ElectionType,
                                     ElectionYear = c.ElectionYear,
                                     WardNum = c.WardNum,
                                     ContributorFirstName = c.ContributorFirstName,
                                     ContributorLastName = c.ContributorLastName,
                                     CandidateLastName = c.CandidateLastName,
                                     ContributionTypeDesc = c.ContributionTypeDesc,
                                     Amount = c.Amount
                                 };

                return reportData.ToArray();                                                // ToArray() method is needed to prevent DbContext error

            }

        }




    }
}
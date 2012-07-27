﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using teamcanada.Models;
using teamcanada.Models.ui;

namespace teamcanada.dal
{
    public class UserReportsDAL
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
                                     ContributionTypeDesc = c.ContributionTypeDesc,
                                 };

                return reportData.ToArray();                                                // ToArray() method is needed to prevent DbContext error

            }

        }




    }
}
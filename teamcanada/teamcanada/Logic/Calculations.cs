using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using teamcanada.Models;
using teamcanada.Models.ui;
using teamcanada.dal;

namespace teamcanada.logic
{


    /***********************************************************/
    /* Logic to calculate total number of votes, contribs, etc */
    /***********************************************************/
    
    public class Calculations
    {
        Contributions totalContrib = new Contributions();
        Results totalResult = new Results();

        float totalAmount;
        int totalVotes;

        public float calculateTotals()
        {
            var sumAmount = ReportsDAL.GetReportData();

            // if getting contributions amount total do this...
            foreach (ReportsUI a in sumAmount)
            {
                totalAmount += a.Amount;
                //Console.WriteLine(i);
            }

            // else if getting votes total do this...
            /* var sumVotes = ReportsDAL.GetReportData();

            foreach (ReportsUI b in sumVotes)
            {
                totalVotes += b.NumVotes;
            } */

            return totalAmount;


        }
    }


    /********************************/
    /* methods for generated reports*/
    /********************************/

    public class GenerateReports
    {

        public GenerateReports GenerateReport(int id, int ElectionYear, String ElectionType, String CandidateFirstName,
                                                String CandidateLastName, String ContributionTypeDesc, String ContributionType/*, int TotalContributionType*/)
        {
            return null;
        }

    }
}
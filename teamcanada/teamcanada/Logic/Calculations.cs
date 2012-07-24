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
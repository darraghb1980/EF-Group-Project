using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using teamcanada.Models;

namespace teamcanada.dal
{

    /* create the methods for the five reports */

    public class Report1DAL
    {

        public Report1DAL GenerateReport1(int id, int ElectionYear, String ElectionType, String CandidateFirstName,
                                                String CandidateLastName, int WardNum, int NumVotes/*, int TotalContributions*/)
        {
            return null;
        }

    }

    public class Report2DAL
    {

        public Report2DAL GenerateReport2(int id, int ElectionYear, String ElectionType, String CandidateFirstName,
                                                String CandidateLastName/*, int TotalContributions, int TotalNumVotes*/) 
        {
            return null;
        }

    }

    public class Report3DAL
    {

        public Report3DAL GenerateReport3(int id, int ElectionYear, String ElectionType /*, int TotalContributions*/)
        {
            return null;
        }

    }

    public class Report4DAL
    {

        public Report4DAL GenerateReport4(int id, int ElectionYear, String ElectionType, String CandidateFirstName,
                                                String CandidateLastName, String WardNum/*, int TotalContributions*/)
        {
            return null;
        }

    }

    public class Report5DAL
    {

        public Report5DAL GenerateReport5(int id, int ElectionYear, String ElectionType, String CandidateFirstName,
                                                String CandidateLastName, String ContributionType/*, int TotalContributionType*/)
        {
            return null;
        }

    }

}
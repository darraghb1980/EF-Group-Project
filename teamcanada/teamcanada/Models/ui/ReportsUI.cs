using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace teamcanada.Models.ui
{
    public class ReportsUI
    {
        public int id { get; set; }
        public String ElectionType { get; set; }
        public int ElectionYear { get; set; }
        public int NumVotes { get; set; }
        public int WardNum { get; set; }
        public String CandidateFirstName { get; set; }
        public String CandidateLastName { get; set; }
        public String ContributorLastName { get; set; }
        public String ContributorFirstName { get; set; }
        public String ContributionTypeDesc { get; set; }
        public float Amount { get; set; }
        public float TotalAmount { get; set; }
        
        //public float Amount { get; set; }  ---- do this after we get a join working

        //public int TotalContributions { get; set; }  
        //public int TotalContributionType { get; set; }  
        //public int TotalNumVotes { get; set; }   
    }
}
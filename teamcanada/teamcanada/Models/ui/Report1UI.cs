using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace teamcanada.Models.ui
{
    public class Report1UI
    {
        public int id { get; set; }
        public String ElectionType {get; set;}
        public int ElectionYear { get; set; } 
        public String CandidateFirstName { get; set; }
        public String CandidateLastName { get; set; }
        public int WardNum { get; set; }
        public int NumVotes { get; set; }
        
        //needs to be created in logic
        //public int TotalContributions { get; set; }    

    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace teamcanada.Models.ui
{
    public class Report4UI
    {
        public int id { get; set; }
        public String ElectionType { get; set; }
        public int ElectionYear { get; set; }
        public String CandidateFirstName { get; set; }
        public String CandidateLastName { get; set; }
        public String Wardnum { get; set; }

        //public int TotalContributions { get; set; }   

    }
}

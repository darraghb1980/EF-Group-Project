using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace teamcanada.Models.ui
{
    public class ResultsUI
    {
        public int id { get; set; }
        public String ElectionType {get; set;}
        public int ElectionYear { get; set; }
        public int WardNum { get; set; }
        public int ContributionType { get; set; }
        public String CandidateFirstName { get; set; }
        public String CandidateLastName { get; set; }
    }
}

/* this is a model that deals with the views towards the user as opposed to the models that deal with the database */
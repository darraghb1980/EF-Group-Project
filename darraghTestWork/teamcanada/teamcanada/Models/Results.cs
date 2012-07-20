using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Linq.Mapping;
using System.ComponentModel;

namespace teamcanada.Models
{
    
    [Table (Name = "ELECTIONRESULTS")] 
    public class Results
    {
        [Column(IsPrimaryKey = true)]
        public int id { get; set; }
        
        [Column(Name = "ELECTIONTYPE")]
        public String ElectionType { get; set; }

        [Column(Name = "ELECTIONYEAR")]
        public int ElectionYear { get; set; }

        [Column(Name = "WARDNUM")]
        public int WardNum { get; set; }

        [Column(Name = "NUMVOTES")]
        public int NumVotes { get; set; }

        [Column(Name = "CANDIDATELASTTNAME")]
        public String CandidateLastName { get; set; }

        [Column(Name = "CANDIDATEFIRSTNAME")]
        public String CandidateFirstName { get; set; }

        public Results()
        {
        }
        public Results(String _ElectionType, int _ElectionYear, int _WardNum, int _NumVotes, 
                       String _CandidateLastName, String _CandidateFirstName)
        {
            this.ElectionType = _ElectionType;
            this.ElectionYear = _ElectionYear;
            this.WardNum = _WardNum;
            this.NumVotes = _NumVotes;
            this.CandidateLastName = _CandidateLastName;
            this.CandidateFirstName = _CandidateFirstName;
        }


    }
}
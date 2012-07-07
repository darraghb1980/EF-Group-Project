using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Linq.Mapping;

namespace teamcanada.Models
{
    [Table (Name = "ELECTION")] 
    public class Election
    {
        [Column(IsPrimaryKey = true)]
        public int id { get; set; }
        
        [Column(Name = "ELECTIONTYPE")]
        public String electionType { get; set; }

        [Column(Name = "ELECTIONYEAR")]
        public int ElectionYear { get; set; }

        [Column(Name = "TOTALNUMVOTES")]
        public int totalNumVotes { get; set; }

        [Column(Name = "TOTALNUMCANDIDATES")]
        public int totalNumCandidates { get; set; }

        public Election()
        {
        }
        public Election(String _electionType, int _ElectionYear, int _totalNumVotes, int _totalNumCandidates)
        {
            this.electionType = _electionType;
            this.ElectionYear = _ElectionYear;
            this.totalNumVotes = _totalNumVotes;
            this.totalNumCandidates = _totalNumCandidates;
        }


    }
}
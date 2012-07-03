using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Linq.Mapping;

namespace teamcanada.Models
{

    [Table(Name = "CANDIDATE")]
    public class Candidate
    {

        [Column(IsPrimaryKey = true)]
        public int id { get; set; }

        [Column(Name = "CANDIDATEFIRSTNAME")]
        public String candidateFirstName { get; set; }

        [Column(Name = "CANDIDATELASTNAME")]
        public String candidateLastName { get; set; }

        [Column(Name = "NUMVOTES")]
        public int numVotes { get; set; }

        [Column(Name = "TOTALCONTRIBUTIONS")]
        public float totalContributions { get; set; }

        public Candidate()
        {
        }
        public Candidate(String _candidateFirstName, String _candidateLastName, int _numVotes, float _totalContributions)
        {
            this.candidateFirstName = _candidateFirstName;
            this.candidateLastName = _candidateLastName;
            this.numVotes = _numVotes;
            this.totalContributions = _totalContributions;
        }

    }
}
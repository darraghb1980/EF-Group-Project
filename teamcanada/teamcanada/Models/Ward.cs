using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Linq.Mapping;

namespace teamcanada.Models
{
    [Table(Name = "WARD")] 
    public class Ward
    {

        [Column(IsPrimaryKey = true)]
        public int id { get; set; }

        [Column(Name = "WARDNUM")]
        public int wardNum { get; set; }

        [Column(Name = "NUMCANDIDATES")]
        public int numCandidates { get; set; } 

        [Column(Name = "WARDNAME")]
        public String wardName { get; set; }

        [Column(Name = "TOTALWARDCONTRIBUTIONS")]
        public float totalWardContributions { get; set; }

        public Ward()
        { 
        }

        public Ward(int _wardNum, int _numCandidates, String _wardName, float _totalWardContributions)
        {
            this.wardNum = _wardNum;
            this.numCandidates = _numCandidates;
            this.wardName = _wardName;
            this.totalWardContributions = _totalWardContributions;
        }


    }
}
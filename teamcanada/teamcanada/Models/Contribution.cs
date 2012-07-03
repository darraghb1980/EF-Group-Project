using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Linq.Mapping;

namespace teamcanada.Models
{

    [Table(Name = "CONTRIBUTION")]
    public class Contribution
    {
        
        [Column(IsPrimaryKey = true)]
        public int id { get; set; }

        [Column(Name = "AMOUNT")]
        public float amount { get; set; }

        [Column(Name = "CONTRIBUTIONTYPE")]
        public String contributionType {get; set;}

        [Column(Name = "CONTRIBUTORTYPE")]
        public String contributorType { get; set; }

        public Contribution ()
        {
        }
        public Contribution(float _amount, String _contributionType, String _contributorType)
        {
            this.amount = _amount;
            this.contributionType = _contributionType;
            this.contributorType = _contributorType;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Linq.Mapping;

namespace teamcanada.Models
{
    [Table(Name = "CONTRIBUTOR")]
    
    public class Contributor
    {

        [Column(IsPrimaryKey = true)]
        public int id { get; set; }

        [Column(Name = "CONTRIBUTORFIRSTNAME")]
        public String contributorFirstName { get; set; }

        [Column(Name = "CONTRIBUTORLASTNAME")]
        public String contributorLastName { get; set; }

        [Column(Name = "POSTCODE")]
        public String postCode { get; set; }

        [Column(Name = "RELATIONSHIP")]
        public String relationship { get; set; }

        public Contributor()
        {
        }
        public Contributor(String _contributorFirstName, String _contributorLastName, String _postCode, String _relationship)
        {
            this.contributorFirstName = _contributorFirstName;
            this.contributorLastName = _contributorLastName;
            this.postCode = _postCode;
            this.relationship = _relationship;
        }

    }
}
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

        [Column(Name = "CONTRIBUTORPOSTCODE")]
        public String contributorPostCode { get; set; }

        [Column(Name = "CONTRIBUTORADDRESS")]
        public String contributorAaddress { get; set; }

        [Column(Name = "RELATIONSHIP")]
        public String relationship { get; set; }

        public Contributor()
        {
        }
        public Contributor(String _contributorFirstName, String _contributorLastName, String _contributorPostCode, String _contributorAddress, String _relationship)
        {
            this.contributorFirstName = _contributorFirstName;
            this.contributorLastName = _contributorLastName;
            this.contributorPostCode = _contributorPostCode;
            this.contributorAaddress = _contributorAddress; 
            this.relationship = _relationship;
        }

    }
}
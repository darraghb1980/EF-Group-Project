using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Linq.Mapping;
using System.ComponentModel;

namespace teamcanada.Models
{

    [Table(Name = "ELECTIONCONTRIBUTIONS")]
    public class Contributions
    {
        
        [Column(IsPrimaryKey = true)]
        public int id { get; set; }

        [Column(Name = "ELECTIONTYPE")]
        public String ElectionType { get; set; }

        [Column(Name = "ELECTIONYEAR")]
        public int ElectionYear { get; set; }

        [Column(Name = "CONTRIBUTORLASTNAME")]
        public String ContributorLastName { get; set; }

        [Column(Name = "CONTRIBUTORFIRSTNAME")]
        public String ContributorFirstName { get; set; }

        [Column(Name = "CONTRIBUTORADDRESS")]
        public String ContributorAddress { get; set; }

        [Column(Name = "CONTRIBUTORPOSTCODE")]
        public String ContributorPostCode { get; set; }

        [Column(Name = "WARD_NUM")]
        public int WardNum { get; set; }

        [Column(Name = "AMOUNT")]
        public float Amount { get; set; }

        [Column(Name = "CONTRIBUTIONTYPE")]
        public String ContributionType {get; set;}

        [Column(Name = "CONTRIBUTIONTYPEDESC")]
        public String ContributionTypeDesc { get; set; }

        [Column(Name = "CONTRIBUTORTYPE")]
        public String ContributorType { get; set; }

        [Column(Name = "CONTRIBUTORTYPEDESC")]
        public String ContributorTypeDesc { get; set; }

        [Column(Name = "CANDIDATEFIRSTNAME")]
        public String CandidateFirstName { get; set; }

        [Column(Name = "CANDIDATELASTNAME")]
        public String CandidateLastName { get; set; }


        public Contributions ()
        {
        }
        public Contributions(String _ElectionType, int _ElectionYear, 
                             String _ContributorFirstName, String _ContributorLastName, String _ContributorPostCode,
                             String _ContributorAddress, int _WardNum, float _Amount, String _ContributionType, 
                             String _ContributionTypeDesc, String _ContributorType, String _ContributorTypeDesc, 
                             String _CandidateFirstName, String _CandidateLastName)
        {
            this.ElectionType = _ElectionType;
            this.ElectionYear = _ElectionYear;
            this.ContributorFirstName = _ContributorFirstName;
            this.ContributorLastName = _ContributorLastName;
            this.ContributorPostCode = _ContributorPostCode;
            this.ContributorAddress = _ContributorAddress;
            this.WardNum = _WardNum;            
            this.Amount = _Amount;
            this.ContributionType = _ContributionType;
            this.ContributorTypeDesc = _ContributorTypeDesc;
            this.CandidateFirstName = _CandidateFirstName;
            this.CandidateLastName = _CandidateLastName;

        }
    }
}
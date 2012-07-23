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
        [DisplayName("Election Type")]
        public String ElectionType { get; set; }

        [Column(Name = "ELECTIONYEAR")]
        [DisplayName("Election Year")]
        public int ElectionYear { get; set; }

        [Column(Name = "CONTRIBUTORLASTNAME")]
        [DisplayName("Contributor Surname")]
        public String ContributorLastName { get; set; }

        [Column(Name = "CONTRIBUTORFIRSTNAME")]
        [DisplayName("Contributor First Name")]
        public String ContributorFirstName { get; set; }

        [Column(Name = "CONTRIBUTORADDRESS")]
        [DisplayName("Contributor Address")]
        public String ContributorAddress { get; set; }

        [Column(Name = "CONTRIBUTORPOSTCODE")]
        [DisplayName("Contributor Postcode")]
        public String ContributorPostCode { get; set; }

        [Column(Name = "WARD_NUM")]
        [DisplayName("Ward Number")]
        public int WardNum { get; set; }

        [Column(Name = "AMOUNT")]
        [DisplayName("Amount")]
        public float Amount { get; set; }

        [Column(Name = "CONTRIBUTIONTYPEDESC")]
        [DisplayName("Type of Contribution")]
        public String ContributionTypeDesc { get; set; }

        [Column(Name = "CONTRIBUTORTYPEDESC")]
        [DisplayName("Type of Contributor")]
        public String ContributorTypeDesc { get; set; }

        [Column(Name = "CANDIDATEFIRSTNAME")]
        [DisplayName("Candidate First Name")]
        public String CandidateFirstName { get; set; }

        [Column(Name = "CANDIDATELASTNAME")]
        [DisplayName("Candidate Surname")]
        public String CandidateLastName { get; set; }


        public Contributions ()
        {
        }
        public Contributions(String _ElectionType, int _ElectionYear, 
                             String _ContributorFirstName, String _ContributorLastName, String _ContributorPostCode,
                             String _ContributorAddress, int _WardNum, float _Amount, String _ContributionTypeDesc, 
                             String _ContributorTypeDesc, String _CandidateFirstName, String _CandidateLastName)
        {
            this.ElectionType = _ElectionType;
            this.ElectionYear = _ElectionYear;
            this.ContributorFirstName = _ContributorFirstName;
            this.ContributorLastName = _ContributorLastName;
            this.ContributorPostCode = _ContributorPostCode;
            this.ContributorAddress = _ContributorAddress;
            this.WardNum = _WardNum;            
            this.Amount = _Amount;
            this.ContributionTypeDesc = _ContributionTypeDesc;
            this.ContributorTypeDesc = _ContributorTypeDesc;
            this.CandidateFirstName = _CandidateFirstName;
            this.CandidateLastName = _CandidateLastName;

        }
    }
}
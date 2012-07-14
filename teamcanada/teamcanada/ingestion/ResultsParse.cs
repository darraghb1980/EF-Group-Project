using System;
using System.Collections.Generic;
using System.IO;
using LumenWorks.Framework.IO.Csv;
using teamcanada.Models;

namespace teamcanada.ingestion
{
    public class ResultsParse : AllDataParser
    {

        private String supportedFormat = "csv";
        private StreamReader reader;


           // bring in results data 

        List<Results> AllDataParser.parseResults()
        {
            List<Results> lst = new List<Results>();
            CsvReader csv = new CsvReader(reader, true);
            int fieldCount = csv.FieldCount; 
            
            String[] headers = csv.GetFieldHeaders();

            while (csv.ReadNextRecord())
            {

                Results exObj = new Results();

                for (int i = 0; i < fieldCount; i++)
                {
                    if (headers[i].Equals("id"))
                    {
                    }
                    else if (headers[i].Equals("ELECTIONTYPE"))
                    {
                        exObj.ElectionType = csv[i];
                    }
                    else if (headers[i].Equals("ELECTIONYEAR"))
                    {
                        exObj.ElectionYear = Convert.ToInt32(csv[i]);
                    }
                    else if (headers[i].Equals("WARDNUM"))
                    {
                        exObj.WardNum = Convert.ToInt32(csv[i]);
                    }
                    else if (headers[i].Equals("NUMVOTES"))
                    {
                        exObj.NumVotes = Convert.ToInt32(csv[i]);
                    }
                    else if (headers[i].Equals("CANDIDATELASTNAME"))
                    {
                        exObj.CandidateLastName = csv[i];
                    }
                    else if (headers[i].Equals("CANDIDATEFIRSTNAME"))
                    {
                        exObj.CandidateFirstName = csv[i];
                    }
                                       
                }

                lst.Add(exObj);
            }
            return lst;
        }

 
        // bring in contributions data

        List<Contributions> AllDataParser.parseContributions()
        {
            List<Contributions> lst = new List<Contributions>();
            CsvReader csv = new CsvReader(reader, true);
            int fieldCount = csv.FieldCount;

            String[] headers = csv.GetFieldHeaders();

            while (csv.ReadNextRecord())
            {

                Contributions exObj = new Contributions();

                for (int i = 0; i < fieldCount; i++)
                {
                    if (headers[i].Equals("id"))
                    {
                    }
                    else if (headers[i].Equals("ELECTIONTYPE"))
                    {
                        exObj.ElectionType = csv[i];
                    }
                    else if (headers[i].Equals("ELECTIONYEAR"))
                    {
                        exObj.ElectionYear = Convert.ToInt32(csv[i]);
                    }
                    else if (headers[i].Equals("CONTRIBUTORLASTNAME"))
                    {
                        exObj.ContributorLastName = csv[i];
                    }
                    else if (headers[i].Equals("CONTRIBUTORFIRSTNAME"))
                    {
                        exObj.ContributorFirstName = csv[i];
                    }
                    else if (headers[i].Equals("CONTRIBUTORADDRESS"))
                    {
                        exObj.ContributorAddress = csv[i];
                    }
                    else if (headers[i].Equals("CONTRIBUTORPOSTCODE"))
                    {
                        exObj.ContributorPostCode = csv[i];
                    }
                    else if (headers[i].Equals("WARDNUM"))
                    {
                        exObj.WardNum = Convert.ToInt32(csv[i]);
                    }
                    else if (headers[i].Equals("AMOUNT"))
                    {
                        exObj.Amount = Convert.ToSingle(csv[i]);
                    }
                    else if (headers[i].Equals("CONTRIBUTIONTYPEDESC"))
                    {
                        exObj.ContributionTypeDesc = csv[i];
                    }
                    else if (headers[i].Equals("CONTRIBUTORTYPEDESC"))
                    {
                        exObj.ContributorTypeDesc = csv[i];
                    }
                    else if (headers[i].Equals("CANDIDATEFIRSTNAME"))
                    {
                        exObj.CandidateFirstName = csv[i];
                    }
                    else if (headers[i].Equals("CANDIDATELASTNAME"))
                    {
                        exObj.CandidateLastName = csv[i];
                    }



                }

                lst.Add(exObj);
            }
            return lst;
        }


        void AllDataParser.setStreamSource(StreamReader reader)
        {
            this.reader = reader;
        }

        bool AllDataParser.supportsType(string format)
        {
            // to cater for the null test
            if (format == null)
            {
                return false;
            }

            if (format.Equals(supportedFormat))
            {
                return true;
            }
            return false;

        }
  
    }
}
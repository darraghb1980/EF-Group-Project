using System;
using System.Collections.Generic;
using System.IO;
using LumenWorks.Framework.IO.Csv;
using teamcanada.Models;

namespace teamcanada.ingestion
{
    public class CSVParser : electionDataParser
    {

        private String supportedFormat = "csv";
        private StreamReader reader;


           // bring in election model 

        List<Election> electionDataParser.parseElection()
        {
            List<Election> lst = new List<Election>();
            CsvReader csv = new CsvReader(reader, true);
            int fieldCount = csv.FieldCount; 
            
            String[] headers = csv.GetFieldHeaders();

            while (csv.ReadNextRecord())
            {

                Election exObj = new Election();

                for (int i = 0; i < fieldCount; i++)
                {
                    if (headers[i].Equals("id"))
                    {
                    }
                    else if (headers[i].Equals("ELECTIONTYPE"))
                    {
                        exObj.electionType = csv[i];
                    }
                    else if (headers[i].Equals("ELECTIONYEAR"))
                    {
                        exObj.ElectionYear = Convert.ToInt32(csv[i]);
                    }
                    else if (headers[i].Equals("TOTALNUMVOTES"))
                    {
                        exObj.totalNumVotes = Convert.ToInt32(csv[i]);
                    }
                    else if (headers[i].Equals("TOTALNUMCANDIDATES"))
                    {
                        exObj.totalNumCandidates = Convert.ToInt32(csv[i]);
                    }
                    
                }

                lst.Add(exObj);
            }
            return lst;
        }

        /*
        
        // bring in candidate model

        List<Candidate> electionDataParser.parseCandidate()
        {
            List<Candidate> lst = new List<Candidate>();
            CsvReader csv = new CsvReader(reader, true);
            int fieldCount = csv.FieldCount;

            String[] headers = csv.GetFieldHeaders();

            while (csv.ReadNextRecord())
            {

                Candidate exObj = new Candidate();

                for (int i = 0; i < fieldCount; i++)
                {
                    if (headers[i].Equals("id"))
                    {
                    }
                    else if (headers[i].Equals("CANDIDATEFIRSTNAME"))
                    {
                        exObj.candidateFirstName = csv[i];
                    }
                    else if (headers[i].Equals("CANDIDATELASTNAME"))
                    {
                        exObj.candidateLastName = csv[i];
                    }
                    else if (headers[i].Equals("NUMVOTES"))
                    {
                        exObj.numVotes = Convert.ToInt32(csv[i]);
                    }
                    else if (headers[i].Equals("TOTALNUMCONTRIBUTIONS"))
                    {
                        exObj.totalContributions = Convert.ToInt32(csv[i]);
                    }
                }

                lst.Add(exObj);
            }
            return lst;
        }
         
         */


        void electionDataParser.setStreamSource(StreamReader reader)
        {
            this.reader = reader;
        }

        bool electionDataParser.supportsType(string format)
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
using System;
using System.Collections.Generic;
using System.IO;
using System.Web;
using System.Linq;
using System.Text;
using LumenWorks.Framework.IO;
using LumenWorks.Framework.IO.Csv;
using teamcanada.Models;

namespace teamcanada.ingestion
{
    public class CSVParser : electionDataParser
    {

        private String supportedFormat = "csv";
        private StreamReader reader;

        List<Models.Election> electionDataParser.parseElection()
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
                       //  exObj.ELECTIONTYPE = csv[i];
                    }
                    else if (headers[i].Equals("ELECTIONTYPE"))
                    {
                        exObj.electionType = csv[i];
                    }
                    else if (headers[i].Equals("ELECTIONYEAR"))
                    {
                        exObj.electionYear = csv[i];
                    }
                    else if (headers[i].Equals("TOTALNUMVOTES"))
                    {
                        exObj.totalNumVotes = csv[i];
                    }
                    else if (headers[i].Equals("TOTALNUMCANDIDATES"))
                    {
                        exObj.totalNumCandidates = csv[i];
                    }
                }

                lst.Add(exObj);
            }
            return lst;
        }

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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using LumenWorks.Framework.IO;
using teamcanada.Models;

namespace teamcanada.ingestion
{
    public class CSVParser : IDataParser
    {

        private String supportedFormat = "csv";
        private StreamReader reader;

        List<Models.ExchangeRate> IDataParser.parseExchangeRate()
        {
            CsvReader csv = new CsvReader(reader, true);
            int fieldCount = csv.FieldCount;
            List<ExchangeRate> rates = new List<ExchangeRate>();

            String[] headers = csv.GetFieldHeaders();

            while (csv.ReadNextRecord())
            {

                ExchangeRate exObj = new ExchangeRate();

                for (int i = 0; i < fieldCount; i++)
                {
                    if (headers[i].Equals("fromCurrency"))
                    {
                        exObj.fromCurrency = csv[i];
                    }
                    else if (headers[i].Equals("toCurrency"))
                    {
                        exObj.toCurrency = csv[i];
                    }
                    else if (headers[i].Equals("rate"))
                    {
                        exObj.rate = Convert.ToDouble(csv[i]);
                    }
                }

                rates.Add(exObj);
            }
            return rates;
        }

        void IDataParser.setStreamSource(StreamReader reader)
        {
            this.reader = reader;
        }

        bool IDataParser.supportsType(string format)
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

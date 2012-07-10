using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using LumenWorks.Framework.IO.Csv;
using DemoApplication.Models;

namespace DemoApplication.ingestion
{
    public class CSVParser : IDataParser
    {

        private String supportedFormat = "csv";
        private StreamReader reader; 

        List<Models.ExchangeRate> IDataParser.parseExchangeRates()
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
                    if (headers[i].Equals("fromCurrency")) {
                        exObj.fromCurrency = csv[i];
                    } else if (headers[i].Equals("toCurrency")) {
                        exObj.toCurrency = csv[i];
                    } else if (headers[i].Equals("rate") && !csv[i].Equals("")) {
                        exObj.rate = Convert.ToDouble(csv[i]);
                    }
                }
                
                if (exObj.rate != 0.0) 
                    rates.Add(exObj);
            }

            return rates;
        }

        void IDataParser.setStreamSource(StreamReader reader)
        {
            this.reader = reader;
        }

        public bool supportsType(string format)
        {
            // What if format is null??
            if (format == null)
            {
                return false;
            }

            if (format.Equals(supportedFormat)) {
                return true;
            }
            return false;
        }

           }
}
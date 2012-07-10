using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DemoApplication.Models;
using System.Configuration;

namespace DemoApplication.dal
{
    public class ExchangeRateDAL  
    {
        protected ExchangeDb db = new ExchangeDb();

        public ExchangeRateDAL()
        {
            ConnectionStringSettingsCollection connections = ConfigurationManager.ConnectionStrings;
            if (connections.Count != 0)
            {
                Console.WriteLine();
                System.Diagnostics.Debug.WriteLine("Using ConnectionStrings property");

                //get the collection elements
                foreach (ConnectionStringSettings connection in connections)
                {
                    string name = connection.Name;
                    string provider = connection.ProviderName;
                    string connectionString = connection.ConnectionString;

                    System.Diagnostics.Debug.WriteLine("Name:       {0}", name);
                    System.Diagnostics.Debug.WriteLine("Connection String:       {0}", connectionString);
                    System.Diagnostics.Debug.WriteLine("Provider:       {0}", provider);

                }
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("no connection string is defined");
            }

                
        }

        public ExchangeRate findExchangeRateForConversion(String from, String to)
        {
            List<ExchangeRate> rates = null;
            rates = db.exchangeRates.ToList();

            foreach (ExchangeRate r in rates)
            {
                if (r.toCurrency.Equals(to) && r.fromCurrency.Equals(from))
                {
                    return r;
                }
            }
            return null;
        }

  /*      public ExchangeRate findExchangeRateById(int id) {
            return null;
        }

        public ExchangeRate addExchangeRate(ExchangeRate rate)
        {
            return null;
        }*/
    }
}
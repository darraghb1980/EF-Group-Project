using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using teamcanada.Models;
using System.Configuration;
using teamcanada.ingestion;

namespace teamcanada.dal
{
    public class torontoDAL
    {
        protected torontoDB db = new torontoDB();

       
        /*
         * public torontoDAL()
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


            insertcsv();

        }
         * */

        public void insertcsv()
        {
            List<Results> results = null;
            ResultsLoadCSV import = new ResultsLoadCSV();
            results = import.loadResultsMayoral();

            foreach (Results r in results)
            {

                db.ElectionResults.Add(r);
            }

            db.SaveChanges();

        }
    }
}
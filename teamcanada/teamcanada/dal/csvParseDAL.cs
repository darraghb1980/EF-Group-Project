using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using teamcanada.Models;
using System.Configuration;
using teamcanada.ingestion;

/* This class writes the parsed CSV data into the database */

namespace teamcanada.dal
{
    public class csvParseDAL
    {
        protected torontoDB db = new torontoDB();

        /* if the database is empty, then do not continue with the CSV parsing */

        public csvParseDAL()
        {
         if ((db.ElectionResults.ToList().Count() == 0) && (db.ElectionContributions.ToList().Count() == 0))

           { 
                insertcsv();
           }

        }
     
       /* Start CSV parsing  */

        public void insertcsv()
        {
            List<Results> results = null;
            List<Contributions> contributions = null;

            LoadCSV import = new LoadCSV();

            results = import.loadResults();

            foreach (Results r in results)
            {

                db.ElectionResults.Add(r);
            }

            contributions = import.loadContributions();

            foreach (Contributions r in contributions)
            {

                db.ElectionContributions.Add(r);
            }

            db.SaveChanges();
            
        }
    }


}
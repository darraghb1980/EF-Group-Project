﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using teamcanada.Models;
using System.IO;

namespace teamcanada.ingestion
{
    public class ResultsLoadCSV
    {
        public AllDataParser all_data = new ResultsParse();

        // results

        public List<Results> loadResults()
        {
            List<Results> lst = new List<Results>();
            StreamReader reader = new StreamReader("C:\\EF Project\\EF-Group-Project\\datasets\\final_csv\\all_results.csv", true);
            all_data.setStreamSource(reader);
            lst = all_data.parseResults();
            return lst;

        }

        // contributions 

        public List<Contributions> loadContributions()
        {
            List<Contributions> lst = new List<Contributions>();
            StreamReader reader = new StreamReader("C:\\EF Project\\EF-Group-Project\\datasets\\final_csv\\all_contributions.csv", true);
            all_data.setStreamSource(reader);
            lst = all_data.parseContributions();
            return lst;
    
        }

       
     

    }
}
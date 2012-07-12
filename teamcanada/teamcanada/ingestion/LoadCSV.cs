﻿﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using teamcanada.Models;
using System.IO;

namespace teamcanada.ingestion
{
    public class LoadCSV
    {
        public AllDataParser all_data = new ResultsContribParse();

        // results from mayoral election

        public List<Results> loadResultsMayoral()
        {
            List<Results> lst = new List<Results>();
            StreamReader reader = new StreamReader("C:\\EF Project\\EF-Group-Project\\datasets\\csv\\results_mayoral.csv", true);
            all_data.setStreamSource(reader);
            lst = all_data.parseResults();
            return lst;

        }

        // results from council election

        public List<Results> loadResultsCouncil()
        {
            List<Results> lst = new List<Results>();
            StreamReader reader = new StreamReader("C:\\EF Project\\EF-Group-Project\\datasets\\csv\\results_council.csv", true);
            all_data.setStreamSource(reader);
            lst = all_data.parseResults();
            return lst;

        }

        // contributions from mayoral election

        public List<Contributions> loadContributionsMayoral()
        {
            List<Contributions> lst = new List<Contributions>();
            StreamReader reader = new StreamReader("C:\\EF Project\\EF-Group-Project\\datasets\\csv\\contributions_mayoral.csv", true);
            all_data.setStreamSource(reader);
            lst = all_data.parseContributions();
            return lst;

        }


        // contributions from council election

        public List<Contributions> loadContributionsCouncil()
        {
            List<Contributions> lst = new List<Contributions>();
            StreamReader reader = new StreamReader("C:\\EF Project\\EF-Group-Project\\datasets\\csv\\contributions_council.csv", true);
            all_data.setStreamSource(reader);
            lst = all_data.parseContributions();
            return lst;

        }




    }
}
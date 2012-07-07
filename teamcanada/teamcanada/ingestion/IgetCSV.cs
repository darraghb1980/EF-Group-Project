﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using teamcanada.Models;
using System.IO;

namespace teamcanada.ingestion
{
    public class LoadCSV
    {
        public electionDataParser abc = new CSVParser();

        public List<Election> loadElection()
        {
            List<Election> lst = new List<Election>();
            StreamReader reader = new StreamReader("C:\\EF Project\\EF-Group-Project\\datasets\\election_results\\2006\\Poll_by_Poll_2006-Council.csv", true);
            abc.setStreamSource(reader);
            lst = abc.parseElection();
            return lst;

        }




    }
}
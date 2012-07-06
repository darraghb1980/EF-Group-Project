using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using teamcanada.Models;
using System.IO;

namespace teamcanada.ingestion
{
    interface electionDataParser
    {
        List<Election> parseElection();
        void setStreamSource(StreamReader reader); // streamreader will be defined in the business logic
        Boolean supportsType(String format);
    }
}

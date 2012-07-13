using System;
using System.Collections.Generic;
using System.IO;
using teamcanada.Models;

namespace teamcanada.ingestion
{
    public interface AllDataParser
    {
        List<Results> parseResultsMayoral();
        List<Contributions> parseContributions();
        
        void setStreamSource(StreamReader reader); // streamreader will be defined in the business logic
        Boolean supportsType(String format);
    }
}

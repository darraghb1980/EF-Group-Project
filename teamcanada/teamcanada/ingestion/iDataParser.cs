using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using teamcanada.Models;
using System.IO;

namespace teamcanada.ingestion
{
    interface IDataParser
    {
        List<ExchangeRate> parseExchangeRate();
        void setStreamSource(StreamReader reader); // streamreader will be defined in the business logic
        Boolean supportsType(String format);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DemoApplication.Models;
using System.IO;

namespace DemoApplication.ingestion
{
    interface IDataParser
    {
        List<ExchangeRate> parseExchangeRates();
        void setStreamSource(StreamReader reader);
        Boolean supportsType(String format);
    }
}

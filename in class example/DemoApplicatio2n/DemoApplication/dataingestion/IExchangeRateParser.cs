using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DemoApplication.Models;
using System.IO;

namespace DemoApplication.dataingestion
{
    interface IExchangeRateParser
    {
        public List<ExchangeRate> parseDataToExchangeRate();
        public void setDataSource(StreamReader reader);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoApplication.Models.ui
{
    public class ExchangeUI
    {
        public int id { get; set; }
        public double amount {get; set;}
        public string fromCurrency { get; set; }
        public string toCurrency { get; set; }
        public string comments { get; set; }
    }
}
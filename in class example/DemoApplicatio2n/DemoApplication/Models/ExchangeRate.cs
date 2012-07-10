using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Linq.Mapping;

namespace DemoApplication.Models
{
    [Table (Name="EXCHANGERATES")] 
    public class ExchangeRate
    {
        [Column(IsPrimaryKey = true)]
        public int id {get; set;}
        [Column(Name = "FROMCURRENCY")]
        public String fromCurrency {get; set;}
        [Column(Name = "TOCURRENCY")]
        public String toCurrency {get; set;}
        [Column(Name = "RATE")]
        public double rate {get; set;}

        public ExchangeRate() {
            }
        public ExchangeRate(String _fromCurrency, String _toCurrency, double _rate)
        {
            this.fromCurrency = _fromCurrency;
            this.toCurrency = _toCurrency;
            this.rate = _rate;
        }






    }
}
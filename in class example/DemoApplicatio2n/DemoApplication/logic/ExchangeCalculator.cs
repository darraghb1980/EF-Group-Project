using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DemoApplication.dal;
using DemoApplication.Models;

namespace DemoApplication.logic
{
    public class ExchangeCalculator
    {
        public double calculateExchangeRate(String fromCurrency, String toCurrency, double amount)
        {
            ExchangeRateDAL dal = new ExchangeRateDAL();
            ExchangeRate rate = dal.findExchangeRateForConversion(fromCurrency, toCurrency);
            return rate.rate * amount;
        }
    }
}
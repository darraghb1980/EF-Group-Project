using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using DemoApplication.Models.ui;

namespace DemoApplication.Models
{
    public class ExchangeDb : DbContext
    {
        public DbSet<ExchangeRate> exchangeRates { get; set; }

        public DbSet<ExchangeUI> ExchangeUIs { get; set; }
    }
}
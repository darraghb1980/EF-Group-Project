using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace teamcanada.Models
{
    public class torontoDb : DbContext

    {
        public DbSet<Results> results { get; set; } 
        public DbSet<Contributions> contributions { get; set; }
    }
}
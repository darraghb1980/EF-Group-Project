using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using teamcanada.Models.ui;

namespace teamcanada.Models
{
    public class torontoDB : DbContext
    {
        public DbSet<Results> ElectionResults { get; set; }

        public DbSet<Contributions> ElectionContributions { get; set; }

        public DbSet<ReportsUI> ReportsUI { get; set; }

    }
}
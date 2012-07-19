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
        public DbSet<Report1UI> ResultsUIs { get; set; }
        public DbSet<Report2UI> Report2UI { get; set; }

        public DbSet<Report3UI> Report3UI { get; set; }

        public DbSet<Report4UI> Report4UI { get; set; }

        public DbSet<Report5UI> Report5UI { get; set; }

    }
}
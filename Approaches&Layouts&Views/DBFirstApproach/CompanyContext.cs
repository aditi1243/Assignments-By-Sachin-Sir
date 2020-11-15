using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace DBFirstApproach.Models
{
    public class CompanyContext : DbContext
    {
        public DbSet<Company> Companies { get; set; }


    }
}
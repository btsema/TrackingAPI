using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Tracking.Data.Models;

namespace Tracking.Data.Database
{
    public class MainContext : DbContext
    {

        public MainContext(DbContextOptions<MainContext> options)
           : base(options)
        { }

        public DbSet<Company> Company { get; set; }
        public DbSet<CompanyUnit> CompanyUnits { get; set; }
    }
}

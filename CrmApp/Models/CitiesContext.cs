using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CrmApp.Models
{
    public class CitiesContextDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        public DbSet<Cities> Cities { get; set; }
    }
}
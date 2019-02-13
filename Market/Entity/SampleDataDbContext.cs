using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace Market.Entity
{
    public class SampleDataDbContext:DbContext
    {
        public DbSet<Order> SampleTables { get; set; }
    }
}
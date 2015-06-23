using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace test_task.Models
{
    public class AppContext : DbContext
    {
        public AppContext()
            : base("DefaultConnection")
        { }

        public DbSet<Shop> Shops { get; set; }
        public DbSet<Goods> Goods { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace jobportal.Models
{
    public class JobContext : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<JobContext>(null);
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<user> users { get; set; }
    }
}
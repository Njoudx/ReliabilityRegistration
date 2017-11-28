using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ReliabilityRegistration.Models
{
    
        public class HelpdeskDbContext : DbContext
        {
            public DbSet<Registeration> Users { get; set; }
            public HelpdeskDbContext() : base("name=DefaultConnection")
            {

            }

            public static HelpdeskDbContext Create()
            {
                return new HelpdeskDbContext();
            }
        }
}
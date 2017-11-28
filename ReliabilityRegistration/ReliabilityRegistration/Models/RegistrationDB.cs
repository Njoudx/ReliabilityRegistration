using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ReliabilityRegistration.Models
{
    public class ReliabilityDb : DbContext
        {
        public DbSet<Registeration> Registerations { get; set; }
        public ReliabilityDb() : base("name=DefaultConnection")
            {

            }

            public static ReliabilityDb Create()
            {
                return new ReliabilityDb();
            }
        }
}
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TestMockup.Models;

namespace TestMockup.DAL
{
    public class TestMockupDbContext : DbContext 
    {
        public TestMockupDbContext() : base("db")
        {
            
        }

        public DbSet<User> Users { get; set; }
    }
}
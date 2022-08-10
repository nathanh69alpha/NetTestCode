using EF6Demo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EF6Demo.Data
{
    public class SchoolContext: DbContext
    {
        public SchoolContext() : base("name=SchoolDBConnectionString")
        {
            
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Teacher> Teachers { get; set; }


  
        }
}
using Microsoft.EntityFrameworkCore;
using MyRepositoryAndUOW.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyRepositoryAndUOW
{
    public class SchoolContext : DbContext
    {
        public SchoolContext() 
        {
            
        }

        public DbSet<Student> Students { get; set; }  
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Course> Courses { get; set; }

    }
}

using Microsoft.EntityFrameworkCore;
using MyRepositoryAndUOW.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyRepositoryAndUOW
{
    public class SchoolContext : DbContext
    {
        //An instance of the context class represents "Unit of Work" and Repository Pattern wherein it can combine multiple changes under a single database transaction.
        public SchoolContext() 
        {
            
        }

        public DbSet<Student> Students { get; set; }  // an entity is a class that maps to a database table.
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Course> Courses { get; set; }

    }
}

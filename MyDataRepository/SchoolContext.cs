using MyDataRepository.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace MyDataRepository
{
    public class SchoolContext : DbContext
    {
        static string connectionString = "Data Source=localhost;Initial Catalog=SchoolDb;Integrated Security=SSPI;";

        //An instance of the context class represents "Unit of Work" and Repository Pattern wherein it can combine multiple changes under a single database transaction.
        public SchoolContext(): base(connectionString)
        {
            
        }

        public DbSet<Student> Students { get; set; }  // an entity is a class that maps to a database table.
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Subject> Subjects { get; set; }
    }
}

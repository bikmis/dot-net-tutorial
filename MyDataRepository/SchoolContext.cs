using MyDataRepository.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;
using System.Configuration;

namespace MyDataRepository
{
    internal class SchoolContext : DbContext
    {
        /* This library is built using .net framework and so .net core mvc cannot use it.
           add a reference to System.Configuration to use ConfigurationManager,
           SchoolDb should be a ConfigurationString in web.config of the calling project as follows:
           <connectionStrings>
                <add name="SchoolDb"
                     connectionString="Data Source=localhost; Initial Catalog=SchoolDb; Integrated Security=True;"
                     providerName="System.Data.SqlClient" />
           </connectionStrings>
         */
        static string connectionString = ConfigurationManager.ConnectionStrings["SchoolDb"].ToString(); //"Data Source=localhost;Initial Catalog=SchoolDb;Integrated Security=true;";

        //An instance of the context class represents "Unit of Work" and Repository Pattern wherein it can combine multiple changes under a single database transaction.
        internal SchoolContext(): base(connectionString)
        {
            
        }

        public DbSet<Student> Students { get; set; }  // an entity is a class that maps to a database table.
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Subject> Subjects { get; set; }
    }
}

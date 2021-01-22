using MyDataRepository.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;
using System.Configuration;
using System.Data.Entity.Infrastructure;

namespace MyDataRepository
{
    public class SchoolContext : DbContext
    {
        //An instance of the context class represents "Unit of Work" and Repository Pattern wherein it can combine multiple changes under a single database transaction.
        internal SchoolContext(string connectionString) : base(connectionString)
        {
            
        }

        public DbSet<Student> Students { get; set; }  // an entity is a class that maps to a database table.
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Subject> Subjects { get; set; }
    }

    public class SchoolContextFactory : IDbContextFactory<SchoolContext>
    {
        /* This library is built using .net framework.
           Add a reference to System.Configuration to use ConfigurationManager to access configuration string from web.config or app.config.
           SchoolDb should be added to ConfigurationStrings element in the web.config of the mvc client project and the app.config of this project.
           Set this project as the Startup Project for running update-database using the configuraion string in the app.config of this project.
           Set the calling MVC project as the startup Project to run using the client's configuration string.
            <connectionStrings>
                <add name="SchoolDb"
                     connectionString="Data Source=localhost; Initial Catalog=SchoolDb; Integrated Security=True;"
                     providerName="System.Data.SqlClient" />
            </connectionStrings>
        */

        static string connectionString = ConfigurationManager.ConnectionStrings["SchoolDb"].ToString();
        public SchoolContext Create()
        {
            return new SchoolContext(connectionString);
        }
    }
}

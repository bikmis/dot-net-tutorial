﻿using MyDataWithEF6.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;
using System.Configuration;
using System.Data.Entity.Infrastructure;

namespace MyDataWithEF6
{
    public class SchoolDbContext : DbContext
    {
        //An instance of the context class represents "Unit of Work" and Repository Pattern wherein it can combine multiple changes under a single database transaction.
        internal SchoolDbContext(string connectionString) : base(connectionString)
        {
            // Database.SetInitializer<SchoolDbContext>(null); //disable initializer
            // Database.SetInitializer<SchoolContext>(new CreateDatabaseIfNotExists<SchoolDbContext>()); //default
            // Database.SetInitializer<SchoolContext>(new DropCreateDatabaseAlways<SchoolDbContext>()); //every run drops and creates a database
            // Database.SetInitializer<SchoolContext>(new DropCreateDatabaseIfModelChanges<SchoolDbContext>()); //every run drops and creates a database only if a model has changed
        }

        public DbSet<Student> Students { get; set; }  // an entity is a class that maps to a database table.
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Subject> Subjects { get; set; }
    }

    public class SchoolContextFactory : IDbContextFactory<SchoolDbContext>
    {
        /* This library is built using .net framework.
           Add a reference to System.Configuration to use ConfigurationManager to access configuration string from web.config or app.config.
           SchoolDb should be added to ConfigurationStrings element in the web.config of the mvc client project (.net framework) and the app.config of this project and in the appSettings.json of the .net core mvc project.
           Set this project as the Startup Project for running update-database using the configuraion string in the app.config of this project.
           Set the calling MVC project as the startup Project to run using the client's configuration string.
           
           Connection string in web.config for .net framework mvc project
            <connectionStrings>
                <add name="SchoolDb"
                     connectionString="Data Source=localhost; Initial Catalog=SchoolDb; Integrated Security=True;"
                     providerName="System.Data.SqlClient" />
            </connectionStrings>
           
           Connection string in appsettings.json for .net core mvc projects
             "ConnectionStrings": {
                "SchoolDb": "Data Source=localhost;Initial Catalog=SchoolDb;Integrated Security=true;"
             },
        */

        private string _connectionString;

        public SchoolContextFactory()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["SchoolDb"].ConnectionString;
        }

        public SchoolContextFactory(string connectionString)
        {
            _connectionString = connectionString;
        }

        public SchoolDbContext Create()
        {
            return new SchoolDbContext(_connectionString);
        }
    }
}

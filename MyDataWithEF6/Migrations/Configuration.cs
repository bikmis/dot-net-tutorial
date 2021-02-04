namespace MyDataWithEF6.Migrations
{
    using MyDataWithEF6.Entities;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MyDataWithEF6.SchoolDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MyDataWithEF6.SchoolDbContext dbContext)
        {
            //  This method will be called after migrating to the latest version When you run "update-database".

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            Address[] addresses = new Address[] {
                new Address() { HouseNumber="2479", Street = "Franklin Rd", City ="Fairbanks", State="CA", ZipCode="56173", CreatedDatetime=new DateTime(2021,2,4), CreatedBy="System" },
                new Address() { HouseNumber="3814", Street = "Honey Lime St", City ="Fresco", State="VA", ZipCode="3173", CreatedDatetime=new DateTime(2021,2,4), CreatedBy="System" },
                new Address() { HouseNumber="2641", Street = "George Way", City ="Richmond", State="VA", ZipCode="48194", CreatedDatetime=new DateTime(2021,2,4), CreatedBy="System" },
                new Address() { HouseNumber="6732", Street = "Lincoln Ground Drive", City ="Los Angeles", State="CA", ZipCode="84792", CreatedDatetime=new DateTime(2021,2,4), CreatedBy="System" },
                new Address() { HouseNumber="5822", Street = "Pan Handle", City ="Florence", State="NY", ZipCode="75251", CreatedDatetime=new DateTime(2021,2,4), CreatedBy="System" },
                new Address() { HouseNumber="4976", Street = "Fish Market St", City ="Falls Church", State="VA", ZipCode="87469", CreatedDatetime=new DateTime(2021,2,4), CreatedBy="System" }
            };

            dbContext.Addresses.AddOrUpdate(address => address.HouseNumber, addresses);

            base.Seed(dbContext);
        }
    }
}

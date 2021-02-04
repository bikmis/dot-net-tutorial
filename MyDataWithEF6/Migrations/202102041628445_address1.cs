namespace MyDataWithEF6.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class address1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "Address_HouseNumber", c => c.String(maxLength: 128));
            CreateIndex("dbo.Students", "Address_HouseNumber");
            AddForeignKey("dbo.Students", "Address_HouseNumber", "dbo.Addresses", "HouseNumber");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "Address_HouseNumber", "dbo.Addresses");
            DropIndex("dbo.Students", new[] { "Address_HouseNumber" });
            DropColumn("dbo.Students", "Address_HouseNumber");
        }
    }
}

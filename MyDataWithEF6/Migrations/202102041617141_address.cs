namespace MyDataWithEF6.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class address : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Students", "Address_Id", "dbo.Addresses");
            DropIndex("dbo.Students", new[] { "Address_Id" });
            DropColumn("dbo.Students", "Address_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Students", "Address_Id", c => c.Int());
            CreateIndex("dbo.Students", "Address_Id");
            AddForeignKey("dbo.Students", "Address_Id", "dbo.Addresses", "Id");
        }
    }
}

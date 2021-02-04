namespace MyDataWithEF6.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class address_base_entity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Addresses", "CreatedDatetime", c => c.DateTime(nullable: false));
            AddColumn("dbo.Addresses", "CreatedBy", c => c.String());
            AddColumn("dbo.Addresses", "UpdatedDatetime", c => c.DateTime());
            AddColumn("dbo.Addresses", "UpdatedBy", c => c.String());
            AddColumn("dbo.Addresses", "DeletedDatetime", c => c.DateTime());
            AddColumn("dbo.Addresses", "DeletedBy", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Addresses", "DeletedBy");
            DropColumn("dbo.Addresses", "DeletedDatetime");
            DropColumn("dbo.Addresses", "UpdatedBy");
            DropColumn("dbo.Addresses", "UpdatedDatetime");
            DropColumn("dbo.Addresses", "CreatedBy");
            DropColumn("dbo.Addresses", "CreatedDatetime");
        }
    }
}

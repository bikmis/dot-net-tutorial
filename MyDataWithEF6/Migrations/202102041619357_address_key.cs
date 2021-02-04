namespace MyDataWithEF6.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class address_key : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Addresses");
            AlterColumn("dbo.Addresses", "HouseNumber", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Addresses", "HouseNumber");
            DropColumn("dbo.Addresses", "Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Addresses", "Id", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.Addresses");
            AlterColumn("dbo.Addresses", "HouseNumber", c => c.String());
            AddPrimaryKey("dbo.Addresses", "Id");
        }
    }
}

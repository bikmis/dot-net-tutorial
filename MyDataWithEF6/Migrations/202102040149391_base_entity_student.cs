namespace MyDataWithEF6.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class base_entity_student : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "CreatedDatetime", c => c.DateTime(nullable: false));
            AddColumn("dbo.Students", "CreatedBy", c => c.String());
            AddColumn("dbo.Students", "UpdatedDatetime", c => c.DateTime());
            AddColumn("dbo.Students", "UpdatedBy", c => c.String());
            AddColumn("dbo.Students", "DeletedDatetime", c => c.DateTime());
            AddColumn("dbo.Students", "DeletedBy", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "DeletedBy");
            DropColumn("dbo.Students", "DeletedDatetime");
            DropColumn("dbo.Students", "UpdatedBy");
            DropColumn("dbo.Students", "UpdatedDatetime");
            DropColumn("dbo.Students", "CreatedBy");
            DropColumn("dbo.Students", "CreatedDatetime");
        }
    }
}

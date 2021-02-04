namespace MyDataWithEF6.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inherit_base_entity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "CreatedDatetime", c => c.DateTime(nullable: false));
            AddColumn("dbo.Courses", "CreatedBy", c => c.String());
            AddColumn("dbo.Courses", "UpdatedDatetime", c => c.DateTime());
            AddColumn("dbo.Courses", "UpdatedBy", c => c.String());
            AddColumn("dbo.Courses", "DeletedDatetime", c => c.DateTime());
            AddColumn("dbo.Courses", "DeletedBy", c => c.String());
            AddColumn("dbo.Subjects", "CreatedDatetime", c => c.DateTime(nullable: false));
            AddColumn("dbo.Subjects", "CreatedBy", c => c.String());
            AddColumn("dbo.Subjects", "UpdatedDatetime", c => c.DateTime());
            AddColumn("dbo.Subjects", "UpdatedBy", c => c.String());
            AddColumn("dbo.Subjects", "DeletedDatetime", c => c.DateTime());
            AddColumn("dbo.Subjects", "DeletedBy", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Subjects", "DeletedBy");
            DropColumn("dbo.Subjects", "DeletedDatetime");
            DropColumn("dbo.Subjects", "UpdatedBy");
            DropColumn("dbo.Subjects", "UpdatedDatetime");
            DropColumn("dbo.Subjects", "CreatedBy");
            DropColumn("dbo.Subjects", "CreatedDatetime");
            DropColumn("dbo.Courses", "DeletedBy");
            DropColumn("dbo.Courses", "DeletedDatetime");
            DropColumn("dbo.Courses", "UpdatedBy");
            DropColumn("dbo.Courses", "UpdatedDatetime");
            DropColumn("dbo.Courses", "CreatedBy");
            DropColumn("dbo.Courses", "CreatedDatetime");
        }
    }
}

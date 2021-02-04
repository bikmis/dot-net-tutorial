namespace MyDataWithEF6.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class course_key : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Courses");
            DropColumn("dbo.Courses", "Id");
            AddColumn("dbo.Courses", "Id", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Courses", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Courses");
            AlterColumn("dbo.Courses", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Courses", "Id");
        }
    }
}

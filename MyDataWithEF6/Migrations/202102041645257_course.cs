namespace MyDataWithEF6.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class course : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Students", "Course_Id", "dbo.Courses");
            DropForeignKey("dbo.SubjectCourses", "Subject_Id", "dbo.Subjects");
            DropForeignKey("dbo.SubjectCourses", "Course_Id", "dbo.Courses");
            DropIndex("dbo.Students", new[] { "Course_Id" });
            DropIndex("dbo.SubjectCourses", new[] { "Subject_Id" });
            DropIndex("dbo.SubjectCourses", new[] { "Course_Id" });
            DropColumn("dbo.Students", "Course_Id");
            DropTable("dbo.SubjectCourses");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.SubjectCourses",
                c => new
                    {
                        Subject_Id = c.Int(nullable: false),
                        Course_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Subject_Id, t.Course_Id });
            
            AddColumn("dbo.Students", "Course_Id", c => c.Int());
            CreateIndex("dbo.SubjectCourses", "Course_Id");
            CreateIndex("dbo.SubjectCourses", "Subject_Id");
            CreateIndex("dbo.Students", "Course_Id");
            AddForeignKey("dbo.SubjectCourses", "Course_Id", "dbo.Courses", "Id", cascadeDelete: true);
            AddForeignKey("dbo.SubjectCourses", "Subject_Id", "dbo.Subjects", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Students", "Course_Id", "dbo.Courses", "Id");
        }
    }
}

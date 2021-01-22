namespace MyDataRepository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        HouseNumber = c.String(),
                        Street = c.String(),
                        City = c.String(),
                        State = c.String(),
                        ZipCode = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        MiddleName = c.String(),
                        LastName = c.String(),
                        Gender = c.String(),
                        DOB = c.DateTime(),
                        Address_Id = c.Int(),
                        Course_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Addresses", t => t.Address_Id)
                .ForeignKey("dbo.Courses", t => t.Course_Id)
                .Index(t => t.Address_Id)
                .Index(t => t.Course_Id);
            
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Tuition = c.Double(nullable: false),
                        DurationInYears = c.Double(nullable: false),
                        SchoolName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Subjects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SubjectCourses",
                c => new
                    {
                        Subject_Id = c.Int(nullable: false),
                        Course_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Subject_Id, t.Course_Id })
                .ForeignKey("dbo.Subjects", t => t.Subject_Id, cascadeDelete: true)
                .ForeignKey("dbo.Courses", t => t.Course_Id, cascadeDelete: true)
                .Index(t => t.Subject_Id)
                .Index(t => t.Course_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SubjectCourses", "Course_Id", "dbo.Courses");
            DropForeignKey("dbo.SubjectCourses", "Subject_Id", "dbo.Subjects");
            DropForeignKey("dbo.Students", "Course_Id", "dbo.Courses");
            DropForeignKey("dbo.Students", "Address_Id", "dbo.Addresses");
            DropIndex("dbo.SubjectCourses", new[] { "Course_Id" });
            DropIndex("dbo.SubjectCourses", new[] { "Subject_Id" });
            DropIndex("dbo.Students", new[] { "Course_Id" });
            DropIndex("dbo.Students", new[] { "Address_Id" });
            DropTable("dbo.SubjectCourses");
            DropTable("dbo.Subjects");
            DropTable("dbo.Courses");
            DropTable("dbo.Students");
            DropTable("dbo.Addresses");
        }
    }
}

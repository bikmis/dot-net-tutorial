namespace MyDataRepository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mega_mig : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        AddressId = c.Int(nullable: false, identity: true),
                        HouseNumber = c.String(),
                        Street = c.String(),
                        City = c.String(),
                        State = c.String(),
                        ZipCode = c.String(),
                    })
                .PrimaryKey(t => t.AddressId);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Gender = c.String(),
                        DOB = c.DateTime(),
                        Address_AddressId = c.Int(),
                        Course_CourseId = c.Int(),
                    })
                .PrimaryKey(t => t.StudentId)
                .ForeignKey("dbo.Addresses", t => t.Address_AddressId)
                .ForeignKey("dbo.Courses", t => t.Course_CourseId)
                .Index(t => t.Address_AddressId)
                .Index(t => t.Course_CourseId);
            
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        CourseId = c.Int(nullable: false, identity: true),
                        Tuition = c.Double(nullable: false),
                        DurationInYears = c.Double(nullable: false),
                        SchoolName = c.String(),
                    })
                .PrimaryKey(t => t.CourseId);
            
            CreateTable(
                "dbo.Subjects",
                c => new
                    {
                        SubjectId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Course_CourseId = c.Int(),
                    })
                .PrimaryKey(t => t.SubjectId)
                .ForeignKey("dbo.Courses", t => t.Course_CourseId)
                .Index(t => t.Course_CourseId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Subjects", "Course_CourseId", "dbo.Courses");
            DropForeignKey("dbo.Students", "Course_CourseId", "dbo.Courses");
            DropForeignKey("dbo.Students", "Address_AddressId", "dbo.Addresses");
            DropIndex("dbo.Subjects", new[] { "Course_CourseId" });
            DropIndex("dbo.Students", new[] { "Course_CourseId" });
            DropIndex("dbo.Students", new[] { "Address_AddressId" });
            DropTable("dbo.Subjects");
            DropTable("dbo.Courses");
            DropTable("dbo.Students");
            DropTable("dbo.Addresses");
        }
    }
}

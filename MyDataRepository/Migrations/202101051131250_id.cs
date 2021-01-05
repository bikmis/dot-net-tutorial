namespace MyDataRepository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class id : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Students", "Address_AddressId", "dbo.Addresses");
            DropForeignKey("dbo.Students", "Course_CourseId", "dbo.Courses");
            DropForeignKey("dbo.Subjects", "Course_CourseId", "dbo.Courses");
            RenameColumn(table: "dbo.Students", name: "Address_AddressId", newName: "Address_Id");
            RenameColumn(table: "dbo.Students", name: "Course_CourseId", newName: "Course_Id");
            RenameColumn(table: "dbo.Subjects", name: "Course_CourseId", newName: "Course_Id");
            RenameIndex(table: "dbo.Students", name: "IX_Address_AddressId", newName: "IX_Address_Id");
            RenameIndex(table: "dbo.Students", name: "IX_Course_CourseId", newName: "IX_Course_Id");
            RenameIndex(table: "dbo.Subjects", name: "IX_Course_CourseId", newName: "IX_Course_Id");
            DropPrimaryKey("dbo.Addresses");
            DropPrimaryKey("dbo.Students");
            DropPrimaryKey("dbo.Courses");
            DropPrimaryKey("dbo.Subjects");
            AddColumn("dbo.Addresses", "Id", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Students", "Id", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Courses", "Id", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Subjects", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Addresses", "Id");
            AddPrimaryKey("dbo.Students", "Id");
            AddPrimaryKey("dbo.Courses", "Id");
            AddPrimaryKey("dbo.Subjects", "Id");
            AddForeignKey("dbo.Students", "Address_Id", "dbo.Addresses", "Id");
            AddForeignKey("dbo.Students", "Course_Id", "dbo.Courses", "Id");
            AddForeignKey("dbo.Subjects", "Course_Id", "dbo.Courses", "Id");
            DropColumn("dbo.Addresses", "AddressId");
            DropColumn("dbo.Students", "StudentId");
            DropColumn("dbo.Courses", "CourseId");
            DropColumn("dbo.Subjects", "SubjectId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Subjects", "SubjectId", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Courses", "CourseId", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Students", "StudentId", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Addresses", "AddressId", c => c.Int(nullable: false, identity: true));
            DropForeignKey("dbo.Subjects", "Course_Id", "dbo.Courses");
            DropForeignKey("dbo.Students", "Course_Id", "dbo.Courses");
            DropForeignKey("dbo.Students", "Address_Id", "dbo.Addresses");
            DropPrimaryKey("dbo.Subjects");
            DropPrimaryKey("dbo.Courses");
            DropPrimaryKey("dbo.Students");
            DropPrimaryKey("dbo.Addresses");
            DropColumn("dbo.Subjects", "Id");
            DropColumn("dbo.Courses", "Id");
            DropColumn("dbo.Students", "Id");
            DropColumn("dbo.Addresses", "Id");
            AddPrimaryKey("dbo.Subjects", "SubjectId");
            AddPrimaryKey("dbo.Courses", "CourseId");
            AddPrimaryKey("dbo.Students", "StudentId");
            AddPrimaryKey("dbo.Addresses", "AddressId");
            RenameIndex(table: "dbo.Subjects", name: "IX_Course_Id", newName: "IX_Course_CourseId");
            RenameIndex(table: "dbo.Students", name: "IX_Course_Id", newName: "IX_Course_CourseId");
            RenameIndex(table: "dbo.Students", name: "IX_Address_Id", newName: "IX_Address_AddressId");
            RenameColumn(table: "dbo.Subjects", name: "Course_Id", newName: "Course_CourseId");
            RenameColumn(table: "dbo.Students", name: "Course_Id", newName: "Course_CourseId");
            RenameColumn(table: "dbo.Students", name: "Address_Id", newName: "Address_AddressId");
            AddForeignKey("dbo.Subjects", "Course_CourseId", "dbo.Courses", "CourseId");
            AddForeignKey("dbo.Students", "Course_CourseId", "dbo.Courses", "CourseId");
            AddForeignKey("dbo.Students", "Address_AddressId", "dbo.Addresses", "AddressId");
        }
    }
}

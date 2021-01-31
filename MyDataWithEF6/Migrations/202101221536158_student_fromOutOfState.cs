namespace MyDataRepository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class student_fromOutOfState : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "FromOutOfState", c => c.Boolean());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "FromOutOfState");
        }
    }
}

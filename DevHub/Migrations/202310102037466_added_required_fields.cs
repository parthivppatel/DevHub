namespace DevHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class added_required_fields : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.candidates", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.candidates", new[] { "UserId" });
            AlterColumn("dbo.candidates", "first_name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.candidates", "surname", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.candidates", "dob", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.candidates", "gender", c => c.String(nullable: false, maxLength: 1));
            AlterColumn("dbo.candidates", "email", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.candidates", "UserId", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.candidates", "proficiency", c => c.String());
            CreateIndex("dbo.candidates", "UserId");
            AddForeignKey("dbo.candidates", "UserId", "dbo.AspNetUsers", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.candidates", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.candidates", new[] { "UserId" });
            AlterColumn("dbo.candidates", "UserId", c => c.String(maxLength: 128));
            AlterColumn("dbo.candidates", "email", c => c.String(maxLength: 100));
            AlterColumn("dbo.candidates", "gender", c => c.String(maxLength: 1));
            AlterColumn("dbo.candidates", "dob", c => c.String(maxLength: 20));
            AlterColumn("dbo.candidates", "surname", c => c.String(maxLength: 50));
            AlterColumn("dbo.candidates", "first_name", c => c.String(maxLength: 50));
            CreateIndex("dbo.candidates", "UserId");
            AddForeignKey("dbo.candidates", "UserId", "dbo.AspNetUsers", "Id");
        }
    }
}

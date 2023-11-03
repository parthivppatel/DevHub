namespace DevHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class added_requiredfields : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.companies", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.companies", new[] { "UserId" });
            AlterColumn("dbo.companies", "name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.companies", "email", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.companies", "service", c => c.String(nullable: false));
            AlterColumn("dbo.companies", "UserId", c => c.String(nullable: false, maxLength: 128));
            CreateIndex("dbo.companies", "UserId");
            AddForeignKey("dbo.companies", "UserId", "dbo.AspNetUsers", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.companies", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.companies", new[] { "UserId" });
            AlterColumn("dbo.companies", "UserId", c => c.String(maxLength: 128));
            AlterColumn("dbo.companies", "service", c => c.String());
            AlterColumn("dbo.companies", "email", c => c.String(maxLength: 100));
            AlterColumn("dbo.companies", "name", c => c.String(maxLength: 50));
            CreateIndex("dbo.companies", "UserId");
            AddForeignKey("dbo.companies", "UserId", "dbo.AspNetUsers", "Id");
        }
    }
}

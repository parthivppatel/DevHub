namespace DevHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cascade_true_in_company : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.companies", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.companies", new[] { "UserId" });
            CreateIndex("dbo.companies", "UserId");
            AddForeignKey("dbo.companies", "UserId", "dbo.AspNetUsers", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.companies", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.companies", new[] { "UserId" });
            CreateIndex("dbo.companies", "UserId");
            AddForeignKey("dbo.companies", "UserId", "dbo.AspNetUsers", "Id");
        }
    }
}

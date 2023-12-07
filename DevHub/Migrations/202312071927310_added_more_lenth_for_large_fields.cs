namespace DevHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class added_more_lenth_for_large_fields : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.candidates", "about_me", c => c.String(nullable: false, maxLength: 2500));
            AlterColumn("dbo.jobs", "qualification", c => c.String(maxLength: 2500));
            AlterColumn("dbo.jobs", "responsibilities", c => c.String(maxLength: 2500));
            AlterColumn("dbo.jobs", "experience", c => c.String(maxLength: 2500));
            AlterColumn("dbo.jobs", "description", c => c.String(nullable: false, maxLength: 2500));
            AlterColumn("dbo.companies", "overview", c => c.String(maxLength: 2500));
            AlterColumn("dbo.companies", "services", c => c.String(nullable: false, maxLength: 2500));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.companies", "services", c => c.String(nullable: false, maxLength: 500));
            AlterColumn("dbo.companies", "overview", c => c.String(maxLength: 500));
            AlterColumn("dbo.jobs", "description", c => c.String(nullable: false, maxLength: 500));
            AlterColumn("dbo.jobs", "experience", c => c.String(maxLength: 500));
            AlterColumn("dbo.jobs", "responsibilities", c => c.String(maxLength: 500));
            AlterColumn("dbo.jobs", "qualification", c => c.String(maxLength: 500));
            AlterColumn("dbo.candidates", "about_me", c => c.String(nullable: false, maxLength: 500));
        }
    }
}

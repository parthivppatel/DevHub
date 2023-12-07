namespace DevHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class added_required_and_string_max_length : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.candidates", "phone", c => c.String(maxLength: 15));
            AlterColumn("dbo.candidates", "about_me", c => c.String(nullable: false, maxLength: 500));
            AlterColumn("dbo.candidates", "linkedin", c => c.String(maxLength: 200));
            AlterColumn("dbo.candidates", "facebook", c => c.String(maxLength: 200));
            AlterColumn("dbo.candidates", "instagram", c => c.String(maxLength: 200));
            AlterColumn("dbo.candidates", "twitter", c => c.String(maxLength: 200));
            AlterColumn("dbo.jobs", "title", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.jobs", "qualification", c => c.String(maxLength: 500));
            AlterColumn("dbo.jobs", "responsibilities", c => c.String(maxLength: 500));
            AlterColumn("dbo.jobs", "experience", c => c.String(maxLength: 500));
            AlterColumn("dbo.jobs", "email", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.jobs", "phone", c => c.String(maxLength: 15));
            AlterColumn("dbo.jobs", "description", c => c.String(nullable: false, maxLength: 500));
            AlterColumn("dbo.jobs", "job_categoryids", c => c.String(nullable: false));
            AlterColumn("dbo.jobs", "modeids", c => c.String(nullable: false));
            AlterColumn("dbo.jobs", "skillids", c => c.String(nullable: false));
            AlterColumn("dbo.companies", "phone", c => c.String(maxLength: 15));
            AlterColumn("dbo.companies", "overview", c => c.String(maxLength: 500));
            AlterColumn("dbo.companies", "services", c => c.String(nullable: false, maxLength: 500));
            AlterColumn("dbo.companies", "facebook", c => c.String(maxLength: 200));
            AlterColumn("dbo.companies", "instagram", c => c.String(maxLength: 200));
            AlterColumn("dbo.companies", "linkedin", c => c.String(maxLength: 200));
            AlterColumn("dbo.companies", "twitter", c => c.String(maxLength: 200));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.companies", "twitter", c => c.String());
            AlterColumn("dbo.companies", "linkedin", c => c.String());
            AlterColumn("dbo.companies", "instagram", c => c.String());
            AlterColumn("dbo.companies", "facebook", c => c.String());
            AlterColumn("dbo.companies", "services", c => c.String(nullable: false));
            AlterColumn("dbo.companies", "overview", c => c.String());
            AlterColumn("dbo.companies", "phone", c => c.String());
            AlterColumn("dbo.jobs", "skillids", c => c.String());
            AlterColumn("dbo.jobs", "modeids", c => c.String());
            AlterColumn("dbo.jobs", "job_categoryids", c => c.String());
            AlterColumn("dbo.jobs", "description", c => c.String());
            AlterColumn("dbo.jobs", "phone", c => c.String());
            AlterColumn("dbo.jobs", "email", c => c.String(maxLength: 100));
            AlterColumn("dbo.jobs", "experience", c => c.String());
            AlterColumn("dbo.jobs", "responsibilities", c => c.String());
            AlterColumn("dbo.jobs", "qualification", c => c.String());
            AlterColumn("dbo.jobs", "title", c => c.String(maxLength: 50));
            AlterColumn("dbo.candidates", "twitter", c => c.String());
            AlterColumn("dbo.candidates", "instagram", c => c.String());
            AlterColumn("dbo.candidates", "facebook", c => c.String());
            AlterColumn("dbo.candidates", "linkedin", c => c.String());
            AlterColumn("dbo.candidates", "about_me", c => c.String(nullable: false));
            AlterColumn("dbo.candidates", "phone", c => c.String());
        }
    }
}

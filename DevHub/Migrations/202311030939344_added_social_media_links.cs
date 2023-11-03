namespace DevHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class added_social_media_links : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.candidates", "twitter", c => c.String());
            AddColumn("dbo.companies", "facebook", c => c.String());
            AddColumn("dbo.companies", "instagram", c => c.String());
            AddColumn("dbo.companies", "linkedin", c => c.String());
            AddColumn("dbo.companies", "twitter", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.companies", "twitter");
            DropColumn("dbo.companies", "linkedin");
            DropColumn("dbo.companies", "instagram");
            DropColumn("dbo.companies", "facebook");
            DropColumn("dbo.candidates", "twitter");
        }
    }
}

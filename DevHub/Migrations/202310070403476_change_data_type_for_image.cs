namespace DevHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class change_data_type_for_image : DbMigration
    {
        public override void Up()
        {
            
            DropColumn("dbo.candidates", "image");
            DropColumn("dbo.companies", "logo");
            DropColumn("dbo.jobs", "document");
            AddColumn("dbo.candidates", "image", c => c.Binary());
            AddColumn("dbo.companies", "logo", c => c.Binary());
            AddColumn("dbo.jobs", "document", c => c.Binary());
        }
        
        public override void Down()
        {

            DropColumn("dbo.candidates", "image");
            DropColumn("dbo.companies", "logo");
            DropColumn("dbo.jobs", "document");
            AddColumn("dbo.candidates", "image", c => c.String());
            AddColumn("dbo.companies", "logo", c => c.String());
            AddColumn("dbo.jobs", "document", c => c.String());
        }
    }
}

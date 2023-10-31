namespace DevHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adding_fields_in_candidate_model : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.candidates", "project", c => c.String());
            AddColumn("dbo.candidates", "instagram", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.candidates", "instagram");
            DropColumn("dbo.candidates", "project");
        }
    }
}

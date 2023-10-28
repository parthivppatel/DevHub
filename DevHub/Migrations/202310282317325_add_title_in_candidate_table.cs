namespace DevHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_title_in_candidate_table : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.candidates", "title", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            DropColumn("dbo.candidates", "title");
        }
    }
}

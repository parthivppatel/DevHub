namespace DevHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class remove_proficiency_field : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.candidates", "proficiency");
        }
        
        public override void Down()
        {
            AddColumn("dbo.candidates", "proficiency", c => c.Int(nullable: false));
        }
    }
}

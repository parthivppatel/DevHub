namespace DevHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class remove_resume_field : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.candidates", "resume");
        }
        
        public override void Down()
        {
            AddColumn("dbo.candidates", "resume", c => c.Binary());
        }
    }
}

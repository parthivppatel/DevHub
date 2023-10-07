namespace DevHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class change_data_type_of_resume_fields : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.candidates", "resume");
            AddColumn("dbo.candidates", "resume",c=>c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.candidates", "resume");
            AddColumn("dbo.candidates", "resume", c => c.String());
        }
    }
}

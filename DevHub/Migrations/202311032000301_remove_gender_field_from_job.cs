namespace DevHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class remove_gender_field_from_job : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.jobs", "gender");
        }
        
        public override void Down()
        {
            AddColumn("dbo.jobs", "gender", c => c.String());
        }
    }
}

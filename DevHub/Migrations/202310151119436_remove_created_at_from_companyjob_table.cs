namespace DevHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class remove_created_at_from_companyjob_table : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.company_job_mapper", "created_at");
        }
        
        public override void Down()
        {
            AddColumn("dbo.company_job_mapper", "created_at", c => c.DateTime(nullable: false));
        }
    }
}

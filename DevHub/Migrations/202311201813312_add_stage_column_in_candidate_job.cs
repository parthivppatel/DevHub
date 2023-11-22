namespace DevHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_stage_column_in_candidate_job : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.candidate_job_mapper", "stage", c => c.String(nullable: false, defaultValueSql: "'Applied'"));
        }
        
        public override void Down()
        {
            DropColumn("dbo.candidate_job_mapper", "stage");
        }
    }
}

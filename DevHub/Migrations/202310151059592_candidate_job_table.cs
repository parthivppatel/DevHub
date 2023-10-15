namespace DevHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class candidate_job_table : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.candidate_job_mapper",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        candidateid = c.Int(nullable: false),
                        jobid = c.Int(nullable: false),
                        created_at = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.candidates", t => t.candidateid, cascadeDelete: true)
                .ForeignKey("dbo.jobs", t => t.jobid, cascadeDelete: true)
                .Index(t => t.candidateid)
                .Index(t => t.jobid);
            
            AddColumn("dbo.company_job_mapper", "created_at", c => c.DateTime(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"));
            DropColumn("dbo.company_job_mapper", "status");
        }
        
        public override void Down()
        {
            AddColumn("dbo.company_job_mapper", "status", c => c.String());
            DropForeignKey("dbo.candidate_job_mapper", "jobid", "dbo.jobs");
            DropForeignKey("dbo.candidate_job_mapper", "candidateid", "dbo.candidates");
            DropIndex("dbo.candidate_job_mapper", new[] { "jobid" });
            DropIndex("dbo.candidate_job_mapper", new[] { "candidateid" });
            DropColumn("dbo.company_job_mapper", "created_at");
            DropTable("dbo.candidate_job_mapper");
        }
    }
}

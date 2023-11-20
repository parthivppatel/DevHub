namespace DevHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class stype_column_in_jobs : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.jobs", "stype", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.jobs", "stype");
        }
    }
}

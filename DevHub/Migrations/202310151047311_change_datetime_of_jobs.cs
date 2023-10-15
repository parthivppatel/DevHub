namespace DevHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class change_datetime_of_jobs : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.jobs", "updated_at", c => c.DateTime());
            AlterColumn("dbo.jobs", "created_at", c => c.DateTime(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"));

        }

        public override void Down()
        {
            AlterColumn("dbo.jobs", "updated_at", c => c.DateTime(nullable: false));
            AlterColumn("dbo.jobs", "created_at", c => c.DateTime());
        }
    }
}

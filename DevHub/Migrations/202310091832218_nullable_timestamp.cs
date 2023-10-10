namespace DevHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nullable_timestamp : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.candidates", "updated_at", c => c.DateTime());
            AlterColumn("dbo.companies", "updated_at", c => c.DateTime());
            AlterColumn("dbo.candidates", "created_at",c=> c.DateTime(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"));
            AlterColumn("dbo.companies", "created_at",c=> c.DateTime(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.companies", "updated_at", c => c.DateTime(nullable: false));
            AlterColumn("dbo.candidates", "updated_at", c => c.DateTime(nullable: false));
        }
    }
}

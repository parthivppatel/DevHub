namespace DevHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class change_in_fields : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.companies", "people", c => c.Int(nullable: false));
            AddColumn("dbo.companies", "services", c => c.String(nullable: false));
            DropColumn("dbo.companies", "service");
        }
        
        public override void Down()
        {
            AddColumn("dbo.companies", "service", c => c.String(nullable: false));
            DropColumn("dbo.companies", "services");
            DropColumn("dbo.companies", "people");
        }
    }
}

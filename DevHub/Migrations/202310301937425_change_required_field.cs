namespace DevHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class change_required_field : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.candidates", "about_me", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.candidates", "about_me", c => c.String());
        }
    }
}

namespace DevHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class change_name_of_field : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.candidates", "middle_name", c => c.String(maxLength: 50));
            DropColumn("dbo.candidates", "last_name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.candidates", "last_name", c => c.String(maxLength: 50));
            DropColumn("dbo.candidates", "middle_name");
        }
    }
}

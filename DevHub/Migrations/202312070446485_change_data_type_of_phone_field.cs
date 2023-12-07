namespace DevHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class change_data_type_of_phone_field : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.candidates", "phone", c => c.String());
            AlterColumn("dbo.jobs", "phone", c => c.String());
            AlterColumn("dbo.companies", "phone", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.companies", "phone", c => c.Long(nullable: false));
            AlterColumn("dbo.jobs", "phone", c => c.Long(nullable: false));
            AlterColumn("dbo.candidates", "phone", c => c.Long(nullable: false));
        }
    }
}

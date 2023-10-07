namespace DevHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class user_roles : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO[dbo].[AspNetRoles] ([Id], [Name]) VALUES(1, 'Candidate')");
            Sql("INSERT INTO[dbo].[AspNetRoles] ([Id], [Name]) VALUES(2, 'Company')");
            Sql("INSERT INTO[dbo].[AspNetRoles] ([Id], [Name]) VALUES(3, 'Admin')");
        }
        
        public override void Down()
        {
        }
    }
}

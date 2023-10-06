namespace DevHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateSkillsModel : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO SkillsModels (Name) VALUES ('C#')");
            Sql("INSERT INTO SkillsModels (Name) VALUES ('ASP.NET')");
            Sql("INSERT INTO SkillsModels (Name) VALUES ('JavaScript')");
            Sql("INSERT INTO SkillsModels (Name) VALUES ('HTML')");
            Sql("INSERT INTO SkillsModels (Name) VALUES ('CSS')");
            Sql("INSERT INTO SkillsModels (Name) VALUES ('Python')");
            Sql("INSERT INTO SkillsModels (Name) VALUES ('Java')");
            Sql("INSERT INTO SkillsModels (Name) VALUES ('SQL')");
            Sql("INSERT INTO SkillsModels (Name) VALUES ('Node.js')");
            Sql("INSERT INTO SkillsModels (Name) VALUES ('React.js')");
            Sql("INSERT INTO SkillsModels (Name) VALUES ('Angular')");
            Sql("INSERT INTO SkillsModels (Name) VALUES ('Vue.js')");
        }
        
        public override void Down()
        {
        }
    }
}

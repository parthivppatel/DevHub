namespace DevHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class job_tabels_data : DbMigration
    {
        public override void Up()
        {
            // ================job_type===================
            Sql("INSERT INTO job_type (name) VALUES ('part-time')");
            Sql("INSERT INTO job_type (name) VALUES ('full-time')");

            // ================job_mode===================
            Sql("INSERT INTO job_mode (name) VALUES ('online')");
            Sql("INSERT INTO job_mode (name) VALUES ('offline')");
            Sql("INSERT INTO job_mode (name) VALUES ('hybrid')");

            // ================job_category===================
            Sql("INSERT INTO job_category (name) VALUES ('Software Developer/Engineer')");
            Sql("INSERT INTO job_category (name) VALUES ('Graphic Designer')");
            Sql("INSERT INTO job_category (name) VALUES ('Web Designer')");
            Sql("INSERT INTO job_category (name) VALUES ('Database Administrator')");
            Sql("INSERT INTO job_category (name) VALUES ('IT Support')");
            Sql("INSERT INTO job_category (name) VALUES ('Business Analyst')");
            Sql("INSERT INTO job_category (name) VALUES ('Project Manager')");
            Sql("INSERT INTO job_category (name) VALUES ('UI/UX Designer')");
        }
        
        public override void Down()
        {
        }
    }
}

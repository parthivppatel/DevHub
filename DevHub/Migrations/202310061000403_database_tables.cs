namespace DevHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class database_tables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.candidates",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        image = c.String(),
                        first_name = c.String(maxLength: 50),
                        last_name = c.String(maxLength: 50),
                        surname = c.String(maxLength: 50),
                        dob = c.String(maxLength: 20),
                        gender = c.String(maxLength: 1),
                        countryid = c.Int(nullable: false),
                        stateid = c.Int(nullable: false),
                        cityid = c.Int(nullable: false),
                        phone = c.Long(nullable: false),
                        email = c.String(maxLength: 100),
                        portfolio_website = c.String(maxLength: 100),
                        address = c.String(maxLength: 255),
                        about_me = c.String(),
                        education = c.String(),
                        experience = c.String(),
                        skillids = c.String(),
                        proficiency = c.Int(nullable: false),
                        linkedin = c.String(),
                        facebook = c.String(),
                        resume = c.String(),
                        UserId = c.String(maxLength: 128),
                        created_at = c.DateTime(nullable: false),
                        updated_at = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.cities", t => t.cityid, cascadeDelete: false)
                .ForeignKey("dbo.countries", t => t.countryid, cascadeDelete: false)
                .ForeignKey("dbo.states", t => t.stateid, cascadeDelete: false)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId)
                .Index(t => t.countryid)
                .Index(t => t.stateid)
                .Index(t => t.cityid)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.cities",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        cityname = c.String(maxLength: 255),
                        stateid = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.states", t => t.stateid, cascadeDelete: true)
                .Index(t => t.stateid);
            
            CreateTable(
                "dbo.states",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        statename = c.String(maxLength: 255),
                        countryid = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.countries", t => t.countryid, cascadeDelete: true)
                .Index(t => t.countryid);
            
            CreateTable(
                "dbo.countries",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(maxLength: 255),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.companies",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(maxLength: 50),
                        logo = c.String(),
                        address = c.String(maxLength: 255),
                        website = c.String(maxLength: 100),
                        email = c.String(maxLength: 100),
                        phone = c.Long(nullable: false),
                        overview = c.String(),
                        service = c.String(),
                        countryid = c.Int(nullable: false),
                        stateid = c.Int(nullable: false),
                        cityid = c.Int(nullable: false),
                        UserId = c.String(maxLength: 128),
                        created_at = c.DateTime(nullable: false),
                        updated_at = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.cities", t => t.cityid, cascadeDelete: false)
                .ForeignKey("dbo.countries", t => t.countryid, cascadeDelete: false)
                .ForeignKey("dbo.states", t => t.stateid, cascadeDelete: false)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId)
                .Index(t => t.countryid)
                .Index(t => t.stateid)
                .Index(t => t.cityid)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.company_job_mapper",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        status = c.String(nullable: false,defaultValueSql: "'applied'"),
                        companyid = c.Int(nullable: false),
                        jobid = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.companies", t => t.companyid, cascadeDelete: true)
                .ForeignKey("dbo.jobs", t => t.jobid, cascadeDelete: true)
                .Index(t => t.companyid)
                .Index(t => t.jobid);
            
            CreateTable(
                "dbo.jobs",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        title = c.String(maxLength: 50),
                        min_salary = c.Long(nullable: false),
                        max_salary = c.Long(nullable: false),
                        qualification = c.String(),
                        responsibilities = c.String(),
                        experience = c.String(),
                        email = c.String(maxLength: 100),
                        phone = c.Long(nullable: false),
                        gender = c.String(),
                        description = c.String(),
                        document = c.String(),
                        job_typeid = c.Int(nullable: false),
                        job_categoryids = c.String(),
                        modeids = c.String(),
                        countryid = c.Int(nullable: false),
                        stateid = c.Int(nullable: false),
                        cityid = c.Int(nullable: false),
                        skillids = c.String(),
                        created_at = c.DateTime(nullable: false),
                        updated_at = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.cities", t => t.cityid, cascadeDelete: false)
                .ForeignKey("dbo.countries", t => t.countryid, cascadeDelete: false)
                .ForeignKey("dbo.job_type", t => t.job_typeid, cascadeDelete: false)
                .ForeignKey("dbo.states", t => t.stateid, cascadeDelete: false)
                .Index(t => t.job_typeid)
                .Index(t => t.countryid)
                .Index(t => t.stateid)
                .Index(t => t.cityid);
            
            CreateTable(
                "dbo.job_type",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.job_category",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.job_mode",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.company_job_mapper", "jobid", "dbo.jobs");
            DropForeignKey("dbo.jobs", "stateid", "dbo.states");
            DropForeignKey("dbo.jobs", "job_typeid", "dbo.job_type");
            DropForeignKey("dbo.jobs", "countryid", "dbo.countries");
            DropForeignKey("dbo.jobs", "cityid", "dbo.cities");
            DropForeignKey("dbo.company_job_mapper", "companyid", "dbo.companies");
            DropForeignKey("dbo.companies", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.companies", "stateid", "dbo.states");
            DropForeignKey("dbo.companies", "countryid", "dbo.countries");
            DropForeignKey("dbo.companies", "cityid", "dbo.cities");
            DropForeignKey("dbo.candidates", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.candidates", "stateid", "dbo.states");
            DropForeignKey("dbo.candidates", "countryid", "dbo.countries");
            DropForeignKey("dbo.candidates", "cityid", "dbo.cities");
            DropForeignKey("dbo.cities", "stateid", "dbo.states");
            DropForeignKey("dbo.states", "countryid", "dbo.countries");
            DropIndex("dbo.jobs", new[] { "cityid" });
            DropIndex("dbo.jobs", new[] { "stateid" });
            DropIndex("dbo.jobs", new[] { "countryid" });
            DropIndex("dbo.jobs", new[] { "job_typeid" });
            DropIndex("dbo.company_job_mapper", new[] { "jobid" });
            DropIndex("dbo.company_job_mapper", new[] { "companyid" });
            DropIndex("dbo.companies", new[] { "UserId" });
            DropIndex("dbo.companies", new[] { "cityid" });
            DropIndex("dbo.companies", new[] { "stateid" });
            DropIndex("dbo.companies", new[] { "countryid" });
            DropIndex("dbo.states", new[] { "countryid" });
            DropIndex("dbo.cities", new[] { "stateid" });
            DropIndex("dbo.candidates", new[] { "UserId" });
            DropIndex("dbo.candidates", new[] { "cityid" });
            DropIndex("dbo.candidates", new[] { "stateid" });
            DropIndex("dbo.candidates", new[] { "countryid" });
            DropTable("dbo.job_mode");
            DropTable("dbo.job_category");
            DropTable("dbo.job_type");
            DropTable("dbo.jobs");
            DropTable("dbo.company_job_mapper");
            DropTable("dbo.companies");
            DropTable("dbo.countries");
            DropTable("dbo.states");
            DropTable("dbo.cities");
            DropTable("dbo.candidates");
        }
    }
}

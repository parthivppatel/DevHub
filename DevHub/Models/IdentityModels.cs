using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace DevHub.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<SkillsModel> SkillsTable { get; set; }
        public DbSet<CountryModel> country { get; set; }
        public DbSet<StateModel> state { get; set; }
        public DbSet<CityModel> city { get; set; }
        public DbSet<CandidateModel> candidate { get; set; }
        public DbSet<JobTypeModel> job_type { get; set; }
        public DbSet<JobModeModel> job_mode { get; set; }
        public DbSet<JobCategoryModel> job_category { get; set; }
        public DbSet<JobModel> jobs { get; set; }
        public DbSet<CompanyModel> company { get; set; }
        public DbSet<CompanyJobMapper> company_job { get; set; }
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}
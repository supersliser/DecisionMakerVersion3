using Azure.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DecisionMakerVersion3.Data
{
    public class ApplicationDbContext: IdentityDbContext<ApplicationUser>
    {

        public DbSet<Project> Project { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Field> Field { get; set; }
        public DbSet<ProjectUser> ProjectUser { get; set; }
        public DbSet<ApplicationUser> AspNetUsers { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
    }
}

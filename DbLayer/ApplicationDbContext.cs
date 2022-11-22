using DbLayer.EntityTypeConfigurations;
using DbLayer.Interfaces;
using Microsoft.EntityFrameworkCore;
using Model;

namespace DbLayer
{
    public class ApplicationDbContext : DbContext, IUsersDbContext, IReportDbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Report> Reports { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}

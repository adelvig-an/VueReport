using DbLayer.EntityTypeConfigurations;
using BussinesLayer.Interfaces;
using Microsoft.EntityFrameworkCore;
using Model;

namespace DbLayer
{
    public class ApplicationDbContext : DbContext, IReportDbContext
    {
        public DbSet<Report> Reports { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ReportConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}

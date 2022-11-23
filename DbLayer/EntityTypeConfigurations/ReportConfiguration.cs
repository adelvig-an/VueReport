using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model;

namespace DbLayer.EntityTypeConfigurations
{
    public class ReportConfiguration : IEntityTypeConfiguration<Report>
    {
        public void Configure(EntityTypeBuilder<Report> builder) 
        {
            builder.HasKey(report => report.Id);
            builder.HasIndex(report => report.Id).IsUnique();
            builder.Property(report => report.Number).HasMaxLength(10);
        }
    }
}

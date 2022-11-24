using Microsoft.EntityFrameworkCore;
using Model;

namespace VueReport.Application.Interfaces
{
    public interface IReportDbContext
    {
        DbSet<Report> Reports { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}

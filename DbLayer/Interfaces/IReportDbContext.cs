using Microsoft.EntityFrameworkCore;
using Model;

namespace DbLayer.Interfaces
{
    public interface IReportDbContext
    {
        DbSet<Report> Reports { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}

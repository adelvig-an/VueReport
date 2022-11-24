using Microsoft.EntityFrameworkCore;
using Model;

namespace BussinesLayer.Interfaces
{
    public interface IReportDbContext
    {
        DbSet<Report> Reports { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}

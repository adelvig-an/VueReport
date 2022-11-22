using DbLayer.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DbLayer
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services,
            IConfiguration configuration)
        {
            var connectionString = configuration["DcConnection"];
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlite(connectionString);
            });
            //services.AddScoped<IUsersDbContext>(provider => provider.GetService<ApplicationDbContext>());
            services.AddScoped<IReportDbContext>(provider => provider.GetService<ApplicationDbContext>());

            return services;
        }
    }
}

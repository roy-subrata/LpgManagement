using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace LpgManagement.Data
{
    public static class ServiceExtention
    {
        public static IServiceCollection AddDatabaseServices(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddDbContext<LgpContext>(option =>
            {
                option.UseSqlServer(configuration.GetConnectionString("LpgDbConnection"));
            });
            return services;
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace WorkDays.Infra.SQLServer.Configuration
{
    public static class SetupSqlServer
    {
        public static void ConfigureDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<WorkDaysDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("SQL")));
        }
    }
}

using Cashflow.Management.Data.AppContext;
using Microsoft.EntityFrameworkCore;

namespace Cashflow.Management.Api.Bootstrap
{
    public static class DataConfiguration
    {
        public static IServiceCollection ConfigureData(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("CashflowManagementDb");
            services.AddDbContext<AppDbContext>(options => options.UseNpgsql(connectionString));

            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

            return services;
        }
    }
}

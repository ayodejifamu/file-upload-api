using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using fileUploadApi.Infrastructure.Data;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.Extensions.DependencyInjection;

namespace fileUploadApi.Infrastructure
{
    public static class StartupSetup
    {
        public static void AddDbContext(this IServiceCollection services, string connectionString) =>
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connectionString
            , optionsBuilder => optionsBuilder.MigrationsAssembly("fileUploadApi.Api")));
    }
}
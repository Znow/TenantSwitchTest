using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace TenantSwitchTest.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class TenantSwitchTestMigrationsDbContextFactory : IDesignTimeDbContextFactory<TenantSwitchTestMigrationsDbContext>
    {
        public TenantSwitchTestMigrationsDbContext CreateDbContext(string[] args)
        {
            TenantSwitchTestEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<TenantSwitchTestMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new TenantSwitchTestMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}

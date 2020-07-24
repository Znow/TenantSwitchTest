using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TenantSwitchTest.Data;
using Volo.Abp.DependencyInjection;

namespace TenantSwitchTest.EntityFrameworkCore
{
    public class EntityFrameworkCoreTenantSwitchTestDbSchemaMigrator
        : ITenantSwitchTestDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreTenantSwitchTestDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the TenantSwitchTestMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<TenantSwitchTestMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}
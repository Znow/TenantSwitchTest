using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace TenantSwitchTest.EntityFrameworkCore
{
    [DependsOn(
        typeof(TenantSwitchTestEntityFrameworkCoreModule)
        )]
    public class TenantSwitchTestEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<TenantSwitchTestMigrationsDbContext>();
        }
    }
}

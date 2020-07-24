using TenantSwitchTest.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace TenantSwitchTest.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(TenantSwitchTestEntityFrameworkCoreDbMigrationsModule),
        typeof(TenantSwitchTestApplicationContractsModule)
        )]
    public class TenantSwitchTestDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}

using Volo.Abp.Modularity;

namespace TenantSwitchTest
{
    [DependsOn(
        typeof(TenantSwitchTestApplicationModule),
        typeof(TenantSwitchTestDomainTestModule)
        )]
    public class TenantSwitchTestApplicationTestModule : AbpModule
    {

    }
}
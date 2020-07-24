using TenantSwitchTest.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace TenantSwitchTest
{
    [DependsOn(
        typeof(TenantSwitchTestEntityFrameworkCoreTestModule)
        )]
    public class TenantSwitchTestDomainTestModule : AbpModule
    {

    }
}
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace TenantSwitchTest.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(TenantSwitchTestHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class TenantSwitchTestConsoleApiClientModule : AbpModule
    {
        
    }
}

using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Components;
using Volo.Abp.DependencyInjection;

namespace TenantSwitchTest.Web
{
    [Dependency(ReplaceServices = true)]
    public class TenantSwitchTestBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "TenantSwitchTest";
    }
}

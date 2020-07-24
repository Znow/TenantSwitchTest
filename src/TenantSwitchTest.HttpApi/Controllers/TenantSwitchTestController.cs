using TenantSwitchTest.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace TenantSwitchTest.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class TenantSwitchTestController : AbpController
    {
        protected TenantSwitchTestController()
        {
            LocalizationResource = typeof(TenantSwitchTestResource);
        }
    }
}
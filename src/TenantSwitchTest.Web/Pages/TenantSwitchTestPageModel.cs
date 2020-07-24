using TenantSwitchTest.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace TenantSwitchTest.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class TenantSwitchTestPageModel : AbpPageModel
    {
        protected TenantSwitchTestPageModel()
        {
            LocalizationResourceType = typeof(TenantSwitchTestResource);
        }
    }
}
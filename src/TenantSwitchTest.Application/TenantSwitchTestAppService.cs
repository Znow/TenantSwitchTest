using System;
using System.Collections.Generic;
using System.Text;
using TenantSwitchTest.Localization;
using Volo.Abp.Application.Services;

namespace TenantSwitchTest
{
    /* Inherit your application services from this class.
     */
    public abstract class TenantSwitchTestAppService : ApplicationService
    {
        protected TenantSwitchTestAppService()
        {
            LocalizationResource = typeof(TenantSwitchTestResource);
        }
    }
}

using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace TenantSwitchTest
{
    public class TenantSwitchTestWebTestStartup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApplication<TenantSwitchTestWebTestModule>();
        }

        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            app.InitializeApplication();
        }
    }
}
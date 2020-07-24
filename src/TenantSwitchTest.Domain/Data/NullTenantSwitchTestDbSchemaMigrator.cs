using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace TenantSwitchTest.Data
{
    /* This is used if database provider does't define
     * ITenantSwitchTestDbSchemaMigrator implementation.
     */
    public class NullTenantSwitchTestDbSchemaMigrator : ITenantSwitchTestDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}
using System.Threading.Tasks;

namespace TenantSwitchTest.Data
{
    public interface ITenantSwitchTestDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}

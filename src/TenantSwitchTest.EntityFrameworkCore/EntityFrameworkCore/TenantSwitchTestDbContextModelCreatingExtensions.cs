using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace TenantSwitchTest.EntityFrameworkCore
{
    public static class TenantSwitchTestDbContextModelCreatingExtensions
    {
        public static void ConfigureTenantSwitchTest(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(TenantSwitchTestConsts.DbTablePrefix + "YourEntities", TenantSwitchTestConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}
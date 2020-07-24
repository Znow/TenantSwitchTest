using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace TenantSwitchTest.Pages
{
    public class Index_Tests : TenantSwitchTestWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}

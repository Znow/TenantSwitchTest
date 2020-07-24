using Volo.Abp.Settings;

namespace TenantSwitchTest.Settings
{
    public class TenantSwitchTestSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(TenantSwitchTestSettings.MySetting1));
        }
    }
}

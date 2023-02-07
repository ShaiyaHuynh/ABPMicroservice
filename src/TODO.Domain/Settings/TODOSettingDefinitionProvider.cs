using Volo.Abp.Settings;

namespace TODO.Settings;

public class TODOSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(TODOSettings.MySetting1));
    }
}

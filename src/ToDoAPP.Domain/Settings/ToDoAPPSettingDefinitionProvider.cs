using Volo.Abp.Settings;

namespace ToDoAPP.Settings;

public class ToDoAPPSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(ToDoAPPSettings.MySetting1));
    }
}

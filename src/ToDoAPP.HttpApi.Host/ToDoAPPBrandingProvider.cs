using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace ToDoAPP;

[Dependency(ReplaceServices = true)]
public class ToDoAPPBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "ToDoAPP";
}

using Volo.Abp.Modularity;

namespace ToDoAPP;

[DependsOn(
    typeof(ToDoAPPApplicationModule),
    typeof(ToDoAPPDomainTestModule)
    )]
public class ToDoAPPApplicationTestModule : AbpModule
{

}

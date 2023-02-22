using ToDoAPP.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace ToDoAPP;

[DependsOn(
    typeof(ToDoAPPEntityFrameworkCoreTestModule)
    )]
public class ToDoAPPDomainTestModule : AbpModule
{

}

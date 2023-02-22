using ToDoAPP.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace ToDoAPP.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ToDoAPPEntityFrameworkCoreModule),
    typeof(ToDoAPPApplicationContractsModule)
    )]
public class ToDoAPPDbMigratorModule : AbpModule
{

}

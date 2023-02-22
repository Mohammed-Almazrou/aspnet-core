using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace ToDoAPP.Data;

/* This is used if database provider does't define
 * IToDoAPPDbSchemaMigrator implementation.
 */
public class NullToDoAPPDbSchemaMigrator : IToDoAPPDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}

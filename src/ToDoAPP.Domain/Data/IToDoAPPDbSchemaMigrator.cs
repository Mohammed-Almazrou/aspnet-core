using System.Threading.Tasks;

namespace ToDoAPP.Data;

public interface IToDoAPPDbSchemaMigrator
{
    Task MigrateAsync();
}

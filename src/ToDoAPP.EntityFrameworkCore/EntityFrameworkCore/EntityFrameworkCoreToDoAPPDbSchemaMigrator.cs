using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ToDoAPP.Data;
using Volo.Abp.DependencyInjection;

namespace ToDoAPP.EntityFrameworkCore;

public class EntityFrameworkCoreToDoAPPDbSchemaMigrator
    : IToDoAPPDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreToDoAPPDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the ToDoAPPDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<ToDoAPPDbContext>()
            .Database
            .MigrateAsync();
    }
}

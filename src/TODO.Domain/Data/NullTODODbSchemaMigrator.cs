using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace TODO.Data;

/* This is used if database provider does't define
 * ITODODbSchemaMigrator implementation.
 */
public class NullTODODbSchemaMigrator : ITODODbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}

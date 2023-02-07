using System.Threading.Tasks;

namespace TODO.Data;

public interface ITODODbSchemaMigrator
{
    Task MigrateAsync();
}

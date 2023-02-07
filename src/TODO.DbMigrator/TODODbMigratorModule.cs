using TODO.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace TODO.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(TODOEntityFrameworkCoreModule),
    typeof(TODOApplicationContractsModule)
    )]
public class TODODbMigratorModule : AbpModule
{

}

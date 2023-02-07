using TODO.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace TODO;

[DependsOn(
    typeof(TODOEntityFrameworkCoreTestModule)
    )]
public class TODODomainTestModule : AbpModule
{

}

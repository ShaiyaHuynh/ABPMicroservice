using Volo.Abp.Modularity;

namespace TODO;

[DependsOn(
    typeof(TODOApplicationModule),
    typeof(TODODomainTestModule)
    )]
public class TODOApplicationTestModule : AbpModule
{

}

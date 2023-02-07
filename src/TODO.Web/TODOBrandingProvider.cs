using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace TODO.Web;

[Dependency(ReplaceServices = true)]
public class TODOBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "TODO";
}

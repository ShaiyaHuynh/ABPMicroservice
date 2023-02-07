using TODO.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace TODO.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class TODOController : AbpControllerBase
{
    protected TODOController()
    {
        LocalizationResource = typeof(TODOResource);
    }
}

using TODO.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace TODO.Web.Pages;

public abstract class TODOPageModel : AbpPageModel
{
    protected TODOPageModel()
    {
        LocalizationResourceType = typeof(TODOResource);
    }
}

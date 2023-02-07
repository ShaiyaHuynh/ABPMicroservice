using System;
using System.Collections.Generic;
using System.Text;
using TODO.Localization;
using Volo.Abp.Application.Services;

namespace TODO;

/* Inherit your application services from this class.
 */
public abstract class TODOAppService : ApplicationService
{
    protected TODOAppService()
    {
        LocalizationResource = typeof(TODOResource);
    }
}

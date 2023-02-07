using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace TODO.Web.Pages;

public class IndexModel : TODOPageModel
{
    public void OnGet()
    {

    }

    public async Task OnPostLoginAsync()
    {
        await HttpContext.ChallengeAsync("oidc");
    }
}

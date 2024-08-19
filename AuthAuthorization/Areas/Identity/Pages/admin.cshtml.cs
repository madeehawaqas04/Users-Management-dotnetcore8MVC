using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AuthAuthorization.Areas.Identity.Pages
{
    [Authorize(Roles ="admin")]
    public class adminModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}

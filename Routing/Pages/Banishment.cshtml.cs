using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Routing.Pages
{
    public class BanishmentModel : PageModel
    {
        public IActionResult OnGet()
        {
            return Redirect("https://www.chick-fil-a.com/");
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Routing.Pages
{
    public class CowMoosModel : PageModel
    {
        public int Id;
        public string Cow = "";

        public void OnGet(int id, string cow)
        {
            Id = id;
            Cow = cow;
        }
    }
}

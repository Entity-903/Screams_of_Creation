using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Routing.Pages
{
    public class AllCowsModel : PageModel
    {
		public int Id1;
		public int? Id2;

		public void OnGet(int id1, int? id2)
		{
			Id1 = id1;
			Id2 = id2;
		}
	}
}

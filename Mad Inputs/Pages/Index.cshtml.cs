using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Mad_Inputs.Pages
{
	public class IndexModel : PageModel
	{
		private readonly ILogger<IndexModel> _logger;

		public IndexModel(ILogger<IndexModel> logger)
		{
			_logger = logger;
		}

		public void OnGet()
		{

		}

		public IActionResult OnPost(string Input1, string Input2, string Input3, string Input4, string Input5) 
		{
			// Do we initialize Viewbag somewhere, if at all?
			// If not, how does the program remember passed in values?

			// Read only; cannot set it's value
			//Request.Form[Input1] = Input1;

			ViewBag.First = Input1;
			ViewBag.Second = Input2;
			ViewBag.Third = Input3;
			ViewBag.Fourth = Input4;
			ViewBag.Fifth = Input5;

			return RedirectToPage("Story");
		}
	}
}

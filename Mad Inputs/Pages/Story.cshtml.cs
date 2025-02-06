using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Mad_Inputs.Pages
{
	//[BindProperties]
	public class StoryModel : PageModel
	{
		private readonly ILogger<StoryModel> _logger;

		public string? First { get; set; }
		public string? Second { get; set; }
		public string? Third { get; set; }
		public string? Fourth { get; set; }
		public string? Fifth { get; set; }

		public StoryModel(ILogger<StoryModel> logger)
		{
			_logger = logger;
		}

		public void OnGet()
		{
			
		}

		public void OnPost(string first, string second, string third, string fourth, string fifth)
		{
			First = first;
			Second = second;
			Third = third;
			Fourth = fourth;
			Fifth = fifth;
		}
	}
}

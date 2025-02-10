using DependencyInjection.Pages.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DependencyInjection.Pages
{
	public class IndexModel : PageModel
	{
		private readonly ILoggerService _logger;

		public IndexModel(ILoggerService logger)
		{
			_logger = logger;
		}

		public void OnGet()
		{
			_logger.Log("Index Page OnGet");
		}
	}
}

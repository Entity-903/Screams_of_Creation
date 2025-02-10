using DependencyInjection.Pages.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DependencyInjection.Pages
{
	public class PrivacyModel : PageModel
	{
		private readonly ILoggerService _logger;

		public PrivacyModel(ILoggerService logger)
		{
			_logger = logger;
		}

		public void OnGet()
		{
			_logger.Log("Privacy Page OnGet");
		}
	}
}

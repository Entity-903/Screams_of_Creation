namespace DependencyInjection.Pages.Services
{
	public class DebugLogger : ILoggerService
	{
		public void Log(string message)
		{
			System.Diagnostics.Debug.WriteLine($"Debug Logger: {message}");
		}
	}
}

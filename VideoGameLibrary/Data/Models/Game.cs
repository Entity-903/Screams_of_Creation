using Microsoft.AspNetCore.Mvc.Rendering;
using static System.Formats.Asn1.AsnWriter;

namespace VideoGameLibrary.Data.Models
{
	public class Game
	{
		private static int nextId = 0;

		public int Id { get; private set; } = ++nextId;
		public string Title { get; set; }
		public string Platform { get; set; }
		public string Genre { get; set; }
		public string ESRB_Rating { get; set; }
		public int Year { get; set; }
		public string Image { get; set; }
		public string? LoanedTo { get; set; } = null;
		public DateTime? LoanDate { get; set; } = null;

		public override string ToString()
		{
			return $"Title: {Title}\nPlatform: {Platform} - Genre: {Genre}\nESRB Rating: {ESRB_Rating}\nYear: {Year}\nImage Link: {Image}\nLoaned To: {LoanedTo}\nLoan Date: {LoanDate}";
		}
	}
}

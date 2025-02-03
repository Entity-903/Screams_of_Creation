using System.ComponentModel.DataAnnotations;

namespace SimpleSite.Data.Models
{
	public class Movie
	{
		[Required]
		public string? Title { get; set; }

		[Range(1888, 2025)]
		public int? Year { get; set; } = null;
		public float Score { get; set; }

		public override string ToString()
		{
			return $"{Title} ({Year}) - {Score}/10";
		}
	}
}

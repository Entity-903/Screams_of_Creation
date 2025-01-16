namespace SimpleSite.Data.Models
{
	public class Movie
	{
		public string? Title { get; set; }
		public int? Year { get; set; } = null;
		public float Score { get; set; }

		public override string ToString()
		{
			return $"{Title} ({Year}) - {Score}/10";
		}
	}
}

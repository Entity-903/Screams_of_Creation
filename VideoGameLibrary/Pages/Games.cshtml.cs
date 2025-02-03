using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VideoGameLibrary.Data.Models;

namespace VideoGameLibrary.Pages
{
	public class GamesModel : PageModel
	{
		public List<Game> Games { get; set; } = new List<Game>
		{
			new Game() { Title = "Deep Rock Galactic",            Platform = "PC", Genre = "FPS",          ESRB_Rating = "T",         Year = 2020, Image = "/images/DRG.jpg"            },
			new Game() { Title = "Team Fortress 2",               Platform = "PC", Genre = "FPS",          ESRB_Rating = "M",         Year = 2007, Image = "/images/TF2.jpg"            },
			new Game() { Title = "Ori and the Blind Forest",      Platform = "PC", Genre = "Metroidvania", ESRB_Rating = "E",         Year = 2015, Image = "/images/BlindForest.jpg"    },
			new Game() { Title = "Ori and the Will of the Wisps", Platform = "PC", Genre = "Metroidvania", ESRB_Rating = "E",         Year = 2020, Image = "/images/WillOfTheWisps.jpg" },
			new Game() { Title = "Lethal Company",                Platform = "PC", Genre = "Horror",       ESRB_Rating = "Not Rated", Year = 2023, Image = "/images/LethalCompany.jpg"  }
		};
		public void OnGet()
		{
		}

		
		public IActionResult OnPost(string? endebted, int id)
		{
			Game game = Games.FirstOrDefault(g => id == g.Id);
			if (game != null)
			{
				if (endebted == null)
				{
					game.LoanDate = null;
				}
				else
				{
					game.LoanedTo = endebted;
					game.LoanDate = DateTime.Now;
				}
			}


			// Why does this error? does View really not exist?
			return RedirectToAction("Get");
		}
	}
}

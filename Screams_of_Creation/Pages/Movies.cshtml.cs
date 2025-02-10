using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SimpleSite.Data.Models;
using SimpleSite.Data.Providers;

namespace SimpleSite.Pages
{
    public class MoviesModel : PageModel
    {
        public MovieProvider Provider { get; set; }

        public MoviesModel()
        {
            Provider = new MovieProvider();
        }

        [BindProperty]
        public Movie NewMovie { get; set; }

        public void OnGet()
        {
            NewMovie = new Movie();
        }

        public IActionResult OnPost()
        {
            if (NewMovie != null)
            {
                Provider.Movies.Add(NewMovie);
            }

            return RedirectToAction("Get");
        }
    }
}

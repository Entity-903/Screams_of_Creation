using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SimpleSite.Data.Models;

namespace SimpleSite.Pages
{
    public class MoviesModel : PageModel
    {
        public List<Movie> Movies { get; set; } = new List<Movie>
        {
            new Movie() { Title = "The Prestige", Year = 2006, Score = 8.5f},
            new Movie() { Title = "8-Legged Freaks", Year = 2002, Score = 5.5f},
            new Movie() { Title = "The Purge", Year = 2013, Score = 5.7f},
            new Movie() { Title = "Avatar", Year = 2009, Score = 7.9f},
        };
        public void OnGet()
        {
        }
    }
}

using lilac_blossom_tarot.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;

namespace lilac_blossom_tarot.Pages.Spreads
{
    public class LetGoMoveOnModel : PageModel
    {
        public Cards? DeckResults { get; set; }
        public void OnGet()
        {
            var rawJson = System.IO.File.ReadAllText("wwwroot/deckDescriptions/DeckDescriptions.json");

            DeckResults = JsonSerializer.Deserialize<Cards>(rawJson);
        }
    }
}

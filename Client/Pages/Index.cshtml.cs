using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Client.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private IStarWarsClient _starWarClient;
        public IndexModel(ILogger<IndexModel> logger, IStarWarsClient starWarClient)
        {
            _logger = logger;
            _starWarClient = starWarClient;
        }

        public async void OnGet()
        {
            var book = await _starWarClient.GetBookAsync();
        }
    }
}
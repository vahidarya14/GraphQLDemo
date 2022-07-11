using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Client.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IConferenceClient _koiosGraphQlClient;
        private readonly ILogger<IndexModel> _logger;
    
        public IndexModel(IConferenceClient koiosGraphQlClient,ILogger<IndexModel> logger)
        {
            _koiosGraphQlClient = koiosGraphQlClient;

            _logger = logger;
        }

        public async void OnGet()
        {
           var data = await _koiosGraphQlClient.GetBook.ExecuteAsync();
            if (data.Errors.Count>0)
            {
                _logger.LogWarning(string.Join(',', data.Errors.Select(x => $"{x.Path}={x.Message}")));

            }
        }
    }
}
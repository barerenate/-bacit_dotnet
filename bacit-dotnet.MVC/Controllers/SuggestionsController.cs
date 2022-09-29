using bacit_dotnet.MVC.Models.Suggestions;
using Microsoft.AspNetCore.Mvc;
using bacit_dotnet.MVC.DataAccess;

namespace bacit_dotnet.MVC.Controllers
{
    public class SuggestionsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Save(SuggestionViewModel model) 
        {
            if (string.IsNullOrWhiteSpace(model.Name))
                throw new ArgumentException();
            sqlConnector.SetSuggestion(model);
            return View(model);
        }

        private readonly ILogger<SuggestionsController> _logger;
        private readonly ISqlConnector sqlConnector;

        public SuggestionsController(ILogger<SuggestionsController> logger, ISqlConnector sqlConnector)
        {
            _logger = logger;
            this.sqlConnector = sqlConnector;
        }
    }
    
}

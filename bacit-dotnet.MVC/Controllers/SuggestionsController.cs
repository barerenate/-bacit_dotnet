using bacit_dotnet.MVC.Models.Suggestions;
using bacit_dotnet.MVC.DataAccess;
using Microsoft.AspNetCore.Mvc;
using bacit_dotnet.MVC.DataAccess;

namespace bacit_dotnet.MVC.Controllers
{
    public class SuggestionsController : Controller
    {
        private readonly ILogger<SuggestionsController> _logger;
        private readonly ISqlConnector sqlConnector;

        public SuggestionsController(ILogger<SuggestionsController> logger, ISqlConnector sqlConnector)
        {
            _logger = logger;
            this.sqlConnector = sqlConnector;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Save(SuggestionViewModel model)
        {
<<<<<<< HEAD

            sqlConnector.setSuggestion(model);
            return View(model);
=======
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
>>>>>>> 3253d016b1351f525ae0a514e394a62fed68a5ba
        }
    }
    
}

using bacit_dotnet.MVC.Entities;
using bacit_dotnet.MVC.Models.Suggestions;

namespace bacit_dotnet.MVC.DataAccess
{
    public interface ISqlConnector
    {
        IEnumerable<User> GetUsers();
<<<<<<< HEAD
        void setSuggestion(SuggestionViewModel model);
=======

        void SetSuggestion(SuggestionViewModel model);
>>>>>>> 3253d016b1351f525ae0a514e394a62fed68a5ba
    }
}
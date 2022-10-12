using System.ComponentModel.DataAnnotations;

namespace bacit_dotnet.MVC.Models.Suggestions
{
    public class SuggestionViewModel
    {
        [Required]
        [MinLength(7, ErrorMessage = "Tittel må være lengre")]
        public string Title { get; set; }

        public string Name { get; set; }
        public string Team { get; set; }
        public string Description { get; set; }
        public string TimeStamp { get; set; }

        public string Plan { get; set; }
        public string Do { get; set; }
        public string Study { get; set; }
        public string Act { get; set; }

        public string Status { get; set; }
        public string Responsible { get; set; }
        public string Dept { get; set; }
        public string CaseNum { get; set; }
        public string PicBefore { get; set; }
        public string PicAfter { get; set; }
        public string Timeframe { get; set; }
        public string Deadline { get; set; }
    }
}

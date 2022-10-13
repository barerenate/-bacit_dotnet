namespace bacit_dotnet.MVC.Models.Users
{
    public class UserViewModel
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string EmpNr { get; set; }
        public string Team { get; set; }
        public bool Admin { get; set; }
        public List<string> AvailableRoles { get; set; }
        public string ValididationErrorMessage { get; set; }
    }
}

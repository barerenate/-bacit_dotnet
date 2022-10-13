namespace bacit_dotnet.MVC.Entities
{
    public class User
    {
        public int EmpNr { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public bool Admin { get; set; }
        public string Team { get; set; }
    }
}

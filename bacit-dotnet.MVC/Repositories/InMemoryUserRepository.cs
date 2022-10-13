namespace bacit_dotnet.MVC.Repositories
{
//tar imot en userentity og setter inn i en liste, objektliste
//repository har ansvar for å lagre og hente data

    public class InMemoryUserRepository : IUserRepository
    {
        private List<UserEntity> users;
        public InMemoryUserRepository()
        {
            users = new List<UserEntity>();
        }
        public void Save(UserEntity user)
        {
            users.Add(user);
        }

        public List<UserEntity> GetUsers()
        {
            return users;
        }
    }

    public class UserEntity
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string EmpNr { get; set; }
        public string Team { get; set; }
        public bool Admin { get; set; }

    }
}

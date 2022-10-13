namespace bacit_dotnet.MVC.Repositories
{


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

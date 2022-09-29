using bacit_dotnet.MVC.Entities;
using MySqlConnector;
using bacit_dotnet.MVC.Models.Suggestions;

namespace bacit_dotnet.MVC.DataAccess
{
    public class SqlConnector : ISqlConnector
    {
        private readonly IConfiguration config;

        public SqlConnector(IConfiguration config)
        {
            this.config = config;
        }

        public IEnumerable<User> GetUsers()
        {
            var reader = ReadData("Select id, name, email, phone from users;");

            var users = new List<User>();
            while (reader.Read())
            {
                var user = new User();
                user.Id = reader.GetInt32("id");
                user.Name = reader.GetString(1);
                user.Email = reader.GetString(2);
                user.Phone = reader.GetString(3);
            }
            return users;
        }

        private MySqlDataReader ReadData(string query)
        {
            using var connection = new MySqlConnection(config.GetConnectionString("MariaDb"));
            connection.Open();
            using var command = connection.CreateCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = query;
            return command.ExecuteReader();
        }

        public void SetSuggestion(SuggestionViewModel model) {
            using var connection = new MySqlConnection(config.GetConnectionString("MariaDb"));
            connection.Open();

            var query = "insert into forslag (tittel, navn, team, beskrivelse, tidspunkt) values(@Title, @Name, @Team, @Description, @TimeStamp);";
            
            WriteSuggestion(query, connection, model);
        }

        private void WriteSuggestion(string query, MySqlConnection con, SuggestionViewModel model) 
        {
            using var command = con.CreateCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = query;
            command.Parameters.AddWithValue("@Title", model.Title);
            command.Parameters.AddWithValue("@Name", model.Name);
            command.Parameters.AddWithValue("@Team", model.Team);
            command.Parameters.AddWithValue("@Description", model.Description);
            command.Parameters.AddWithValue("@TimeStamp", model.TimeStamp);
            command.ExecuteNonQuery();
        }

    }
}

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
            var reader = ReadData("Select empnr, name, password, team, admin from users;");

            var users = new List<User>();
            while (reader.Read())
            {
                var user = new User();
                user.EmpNr = reader.GetInt32("Nr");
                user.Name = reader.GetString(1);
                user.Team = reader.GetString(2);
                user.Password = reader.GetString(3);
                user.Admin = reader.GetBoolean(4);
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

<<<<<<< HEAD
        public void setSuggestion(SuggestionViewModel model)
        {
            using var connection = new MySqlConnection(config.GetConnectionString("MariaDb"));
            connection.Open();
            var query = "insert into forslag (tittel, navn, team, beskrivelse, tid, plan, do, study, act, status, responsible, dept, casenum, picbefore, picafter, timeframe, deadline) values (@Title, @Name, @Team, @Description, @TimeStamp, @Plan, @Do, @Study, @Act, @Status, @Responsible, @Dept, @CaseNum, @PicBefore, @PicAfter, @Timeframe, @Deadline)";
            writeSuggestions(query, connection, model);
        }

        private void writeSuggestions(string query, MySqlConnection conn, SuggestionViewModel model)
        {
            using var command = conn.CreateCommand();
=======
        public void SetSuggestion(SuggestionViewModel model) {
            using var connection = new MySqlConnection(config.GetConnectionString("MariaDb"));
            connection.Open();

            var query = "insert into forslag (tittel, navn, team, beskrivelse, tidspunkt) values(@Title, @Name, @Team, @Description, @TimeStamp);";
            
            WriteSuggestion(query, connection, model);
        }

        private void WriteSuggestion(string query, MySqlConnection con, SuggestionViewModel model) 
        {
            using var command = con.CreateCommand();
>>>>>>> 3253d016b1351f525ae0a514e394a62fed68a5ba
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = query;
            command.Parameters.AddWithValue("@Title", model.Title);
            command.Parameters.AddWithValue("@Name", model.Name);
            command.Parameters.AddWithValue("@Team", model.Team);
            command.Parameters.AddWithValue("@Description", model.Description);
            command.Parameters.AddWithValue("@TimeStamp", model.TimeStamp);
<<<<<<< HEAD
            command.Parameters.AddWithValue("@Plan", model.Plan);
            command.Parameters.AddWithValue("@Do", model.Do);
            command.Parameters.AddWithValue("@Study", model.Study);
            command.Parameters.AddWithValue("@Act", model.Act);
            command.Parameters.AddWithValue("@Status", model.Status);
            command.Parameters.AddWithValue("@Responsible", model.Responsible);
            command.Parameters.AddWithValue("@Dept", model.Dept);
            command.Parameters.AddWithValue("@CaseNum", model.CaseNum);
            command.Parameters.AddWithValue("@PicBefore", model.PicBefore);
            command.Parameters.AddWithValue("@PicAfter", model.PicAfter);
            command.Parameters.AddWithValue("@Timeframe", model.Timeframe);
            command.Parameters.AddWithValue("@Deadline", model.Deadline);
            command.ExecuteNonQuery();
        }
=======
            command.ExecuteNonQuery();
        }

>>>>>>> 3253d016b1351f525ae0a514e394a62fed68a5ba
    }

}

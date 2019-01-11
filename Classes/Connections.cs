using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;

namespace Space_Invaders.Classes
{
    class Connections
    {
       public DataTable SQLConnection()
        {
            DataTable table = new DataTable();
            string query = "SELECT Username, Score, Stage, Hits FROM highscorelist ORDER BY Score DESC LIMIT 10";
            string connStr = ConfigurationManager.ConnectionStrings["MySQLConnection"].ConnectionString;

            try
            {
                MySqlConnection con = null;
                using (con = new MySqlConnection(connStr))
                {
                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;

                    con.Open();

                    MySqlDataAdapter da = null;
                    using (da = new MySqlDataAdapter(cmd))
                    {
                        da.Fill(table);
                    }
                    cmd = null;
                }
            }
            catch
            {
                NetworkFail n = new NetworkFail();
                n.Show();
            }
            return table;
        }

        public void InsertData(int Score, int Stage, int Hits)
        {
            string Name = Properties.Settings.Default.Name;
            string query = "INSERT INTO highscorelist (Username, Score, Stage, Hits) VALUES (@Name,@Score,@Stage,@Hits)";
            int res = 0;
            string connStr = ConfigurationManager.ConnectionStrings["MySQLConnection"].ConnectionString;

            MySqlConnection con = null;
            using (con = new MySqlConnection(connStr))
            {
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;

                cmd.Parameters.AddWithValue("Name", Name);
                cmd.Parameters.AddWithValue("Score", Score);
                cmd.Parameters.AddWithValue("Stage", Stage);
                cmd.Parameters.AddWithValue("Hits", Hits);

                con.Open();
                res = cmd.ExecuteNonQuery();
            }
        }
    }
}

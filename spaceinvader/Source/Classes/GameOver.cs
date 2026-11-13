using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Space_Invaders.Classes
{
    class GameOver
    {
        DataTable table = new DataTable();
        public void HighScoreSet(Game g)
        {
                SqlConnection con = null;
                con = new SqlConnection(ConfigurationManager.ConnectionStrings["HighscoreConnection"].ConnectionString);

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into highscorelist (Name, Score, Stage, Hits) values (@Name, @Score, @Stage, @Hits)";
                cmd.Parameters.AddWithValue("@Name", g.Name);
                cmd.Parameters.AddWithValue("@Score", g.Stage);
                cmd.Parameters.AddWithValue("@Stage", g.Score);
                cmd.Parameters.AddWithValue("@Hits", g.Hits);

                con.Open();
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                cmd = null;
                con.Close();
        }
    }
}
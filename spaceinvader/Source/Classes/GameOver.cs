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
                con = new SqlConnection("Server=dedcv2056;Database=dtdbSpaceInvaders;User Id=spaceinvaders;Password=spaceinvaders");

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                string query = "insert into highscorelist (Name, Score, Stage, Hits) values ('" + g.Name + "', " + g.Stage + ", " + g.Score + ", " + g.Hits + ")";
                cmd.CommandText = query;

                con.Open();
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                cmd = null;
                con.Close();
        }
    }
}
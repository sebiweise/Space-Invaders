using Space_Invaders.Classes;
using System;
using System.Data;
using System.Windows.Forms;

namespace Space_Invaders
{
    public partial class HighScore : Form
    {
        public HighScore()
        {
            InitializeComponent();
            viewHighScore();
        }

        public void pictureBox1_Click(object sender, EventArgs e)
        {
            viewHighScore();
        }
        private void viewHighScore()
        {
                Connections c = new Connections();
                viewTable(c.SQLConnection());
        }

        public void viewTable (DataTable table)
        {
            try
            {
                highscorelist.DataSource = table;

                highscorelist.Columns[0].Width = 150;
                highscorelist.Columns[1].Width = 45;
                highscorelist.Columns[2].Width = 45;
                highscorelist.Columns[3].Width = 45;
            }
            catch
            {

            }

        }
    }
}

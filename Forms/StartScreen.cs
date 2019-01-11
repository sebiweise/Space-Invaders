using Space_Invaders.Classes;
using Space_Invaders.cs;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Space_Invaders
{
    public partial class Form1 : Form
    {
        private FireWall f = new FireWall();
        public Form1()
        {
            InitializeComponent();
            f.addRule();
            LabelVersion.Text = "Version:" + Application.ProductVersion;

            TextBox1.Text = Properties.Settings.Default.Name;
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            MainGame m = new MainGame();
            m.ShowDialog();
        }

        private void ButtonQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ButtonHighScore_Click(object sender, EventArgs e)
        {
            HighScore h = new HighScore();

            Properties.Settings.Default.Name = TextBox1.Text;
            Properties.Settings.Default.Save();

            h.ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://space-invaders.link");
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            Settings s = new Settings();

            s.ShowDialog();
        }
    }
}

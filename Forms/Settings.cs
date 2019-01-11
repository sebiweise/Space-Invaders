using System;
using System.Windows.Forms;

namespace Space_Invaders.cs
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int textBoxID = 1;
            ColorPicker(textBoxID);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int textBoxID = 2;
            ColorPicker(textBoxID);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int textBoxID = 3;
            ColorPicker(textBoxID);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int textBoxID = 4;
            ColorPicker(textBoxID);
        }

        private void ColorPicker(int textBoxID)
        {
            DialogResult result = colorDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                TextBox textBox = new TextBox();

                textBox.Name = "textbox" + textBoxID;
                textBox.Text = colorDialog1.Color.ToString();
            }


            Properties.Settings.Default.Save();
        }
    }
}

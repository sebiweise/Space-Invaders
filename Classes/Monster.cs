using System.Drawing;
using System.Windows.Forms;

namespace Space_Invaders.Classes
{
    public class Monster
    {
        public PictureBox PictureBox
        {
            get;
            private set;
        } 

        public Monster(Point location)
        {
            PictureBox = new PictureBox();
            PictureBox.BackColor = SystemColors.ActiveCaptionText;
            PictureBox.Image = Properties.Resources.monster;
            PictureBox.Location = location;
            PictureBox.Size = new Size(62, 62);
            PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox.TabIndex = 2;
            PictureBox.TabStop = false;
        }
        public void MoveLeft(int stage)
        {
            PictureBox.Location = new Point(PictureBox.Location.X - (4 + stage), PictureBox.Location.Y);
        }

        public void MoveRight(int stage)
        {
            PictureBox.Location = new Point(PictureBox.Location.X + (4 + stage), PictureBox.Location.Y);
        }

        public void MoveUp()
        {
            PictureBox.Location = new Point(PictureBox.Location.X, PictureBox.Location.Y - 10);
        }

        public void MoveDown()
        {
            PictureBox.Location = new Point(PictureBox.Location.X, PictureBox.Location.Y + 10);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            PictureBox = new System.Windows.Forms.PictureBox();
            //PictureBox.Name = "monster" + i;
            PictureBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            PictureBox.Image = global::Space_Invaders.Properties.Resources.monster2;
            PictureBox.Location = location;
            PictureBox.Size = new System.Drawing.Size(62, 62);
            PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            PictureBox.TabIndex = 2;
            PictureBox.TabStop = false;
        }
        public void MoveLeft(int stage)
        {
            PictureBox.Location = new System.Drawing.Point(PictureBox.Location.X - (4 + stage), PictureBox.Location.Y);
        }

        public void MoveRight(int stage)
        {
            PictureBox.Location = new System.Drawing.Point(PictureBox.Location.X + (4 + stage), PictureBox.Location.Y);
        }

        public void MoveUp()
        {
            PictureBox.Location = new System.Drawing.Point(PictureBox.Location.X, PictureBox.Location.Y - 10);
        }

        public void MoveDown()
        {
            PictureBox.Location = new System.Drawing.Point(PictureBox.Location.X, PictureBox.Location.Y + 10);
        }
    }
}

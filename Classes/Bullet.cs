using System.Drawing;
using System.Windows.Forms;

namespace Space_Invaders.Classes
{
    public class Bullet
    {
        public Label Label { get; private set; }

        public Bullet(Point location, bool ID)
        {
            Label = new Label();
            Label.AutoSize = true;
            Label.Text = Properties.Settings.Default.BulletStyle;
            if (ID)
            {
                Label.ForeColor = Properties.Settings.Default.BulletColorInvaders;
            }
            else
            {
                Label.ForeColor = Properties.Settings.Default.BulletColorTank;
            }
            Label.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Bold);
            Label.BringToFront();
            Label.Location = location;
        }

        public void MoveUp()
        {
            Label.Location = new Point(Label.Location.X, Label.Location.Y - 20);
        }

        public void MoveDown()
        {
            Label.Location = new Point(Label.Location.X, Label.Location.Y + 20);
        }

        public bool IsHit(Rectangle target)
        {
            return target.IntersectsWith(Label.Bounds);
        }
    }
}

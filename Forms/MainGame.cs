using Space_Invaders.Classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Space_Invaders
{
    public partial class MainGame : Form
    {
        bool GoRight = false;
        bool GoLeft = true;
        public int Hits;
        public int Stage = 1;
        public bool Over = false;
        public int Score = 0;
        Bullet monsterBullet = null;
        Bullet tankBullet = null;
        int Lives = 3;
        List<Monster> monsters = new List<Monster>();
        List<Label> MonsterBullets = new List<Label>();

        PictureBox Monster = new PictureBox();

        public MainGame()
        {
            InitializeComponent();

            LabelScore.Text = Score.ToString();
            LabelStage.Text = Stage.ToString();
            Bullets.Start();

            MonstersDelete();
            MonstersNew();
        }

        //Main Aktion, Key_Down alles starten
        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            Random.Start();
            MonstersMove.Start();
            Label7.Hide();

            string Geschwindgkeit = "15";
            int PositionX = Tank.Location.X;
            int PositionY = Tank.Location.Y;
            int PositionLabelX = Bullet1.Location.X;
            int PositionLabelY = Bullet1.Location.Y;
            if (e.KeyCode == Keys.Right && PositionX + Tank.Width < this.Width - 20)
            {
                Tank.Location = new Point(PositionX += Convert.ToInt32(Geschwindgkeit), Tank.Location.Y);
                if (PositionLabelY == 525)
                {
                    Bullet1.Location = new Point(PositionLabelX += Convert.ToInt32(Geschwindgkeit), Bullet1.Location.Y);
                }
            }

            if (e.KeyCode == Keys.Left && PositionX > 15)
            {
                Tank.Location = new Point(PositionX -= Convert.ToInt32(Geschwindgkeit), Tank.Location.Y);
                if (PositionLabelY == 525)
                {
                    Bullet1.Location = new Point(PositionLabelX -= Convert.ToInt32(Geschwindgkeit), Bullet1.Location.Y);
                }
            }
            PositionLabelY = Bullet1.Location.Y;

            if (e.KeyCode == Keys.Space
                && tankBullet == null)
            {
                bool ID = false;

                tankBullet = new Bullet(new Point(PositionX += 24, PositionY), ID);
                Controls.Add(tankBullet.Label);
                panel2.BringToFront();
            }
            if (Over && e.KeyCode == Keys.Space)
            {
                GameOver();
            }
        }

        //Timer für Bullets, bewegt, bzw. bestimmt die Location der Kugel des Panzers
        private void Bullets_Tick(object sender, EventArgs e)
        {
            if (tankBullet != null)
            {
                tankBullet.MoveUp();

                Monster monsterToDelete = null;
                foreach (Monster monster in monsters)
                {
                    if (tankBullet != null)
                    {
                        if (tankBullet.IsHit(monster.PictureBox.Bounds))
                        {
                            Controls.Remove(monster.PictureBox);
                            Controls.Remove(tankBullet.Label);
                            tankBullet = null;
                            Score += 10;
                            Hits += 1;
                            LabelScore.Text = Score.ToString();
                            monsterToDelete = monster;
                            break;
                        }
                    }
                }
                if (monsterToDelete != null)
                {
                    monsters.Remove(monsterToDelete);
                }

                if (tankBullet != null
                    && tankBullet.Label.Location.Y < 20)
                {
                    Controls.Remove(tankBullet.Label);
                    tankBullet = null;
                }
            }


            if (monsterBullet != null)
            {
                monsterBullet.MoveDown();
                if(monsterBullet.IsHit(Tank.Bounds))
                {
                    Lives -= 1;
                    Score -= 10;
                    LabelScore.Text = Score.ToString();
                    TankLives();
                    Controls.Remove(monsterBullet.Label);
                    monsterBullet = null;
                }
                if (tankBullet != null && monsterBullet != null)
                {
                    if (monsterBullet.IsHit(tankBullet.Label.Bounds))
                    {
                        Controls.Remove(monsterBullet.Label);
                        Controls.Remove(tankBullet.Label);
                        monsterBullet = null;
                        tankBullet = null;

                        Score += 5;
                        LabelScore.Text = Score.ToString();

                        if (Lives < 3)
                        {
                            Lives += 1;
                            TankLives();
                        }                        
                    }
                }
                if(monsterBullet != null
                    && monsterBullet.Label.Location.Y > Height)
                {
                    Controls.Remove(monsterBullet.Label);
                    monsterBullet = null;
                }
            }
        }

        //Timer für MonsterMove, monster werden von Rechts nach Links bewegt
        private void MonstersMove_Tick(object sender, EventArgs e)
        {
            SuspendLayout();
            foreach (Monster monster in monsters)
            {
                int positionY = monster.PictureBox.Location.Y;
                int positionX = monster.PictureBox.Location.X;

                if (GoLeft && positionX < 18)
                {
                    GoLeft = false;
                    GoRight = true;
                }
                else if (GoRight && (positionX + monster.PictureBox.Width) > this.Width - 60)
                {
                    GoRight = false;
                    GoLeft = true;
                }
                if (GoLeft)
                {
                    monster.MoveLeft(Stage);
                }
                else if (GoRight)
                {
                    monster.MoveRight(Stage);
                }
            }
            ResumeLayout();

        }
       

        //Timer für Random, bestimmt den Zufall, des Monsterschusses, Bullet wird zufällig von einem Monster abgefeuert
        private void Random_Tick(object sender, EventArgs e)
        {
            if (monsters.Count > 0)
            {
                Random rnd = new Random(DateTime.Now.Second);
                if (monsterBullet == null)
                {
                    bool ID = true;
                    PictureBox monster = monsters[rnd.Next(monsters.Count)].PictureBox;

                    monsterBullet = new Bullet(new Point(monster.Location.X, monster.Location.Y), ID);
                    MonstersAttack.Start();
                    Controls.Add(monsterBullet.Label);
                }
            }
            else
            {
                MonstersNew();
                Stage += 1;
                LabelStage.Text = Stage.ToString();
            }
        }

        //Switch bestimmt die Aktion, die nach dem Treffer einer Kugel der Monster ausgeführt wird
        public void TankLives()
        {
             switch (Lives)
            {
                case 0:
                    Live3.Hide();
                    Live2.Hide();
                    Live1.Hide();
                    End();
                    break;
                case 1:
                    Live3.Hide();
                    Live2.Hide();
                    Live1.Show();
                    break;
                case 2:
                    Live3.Hide();
                    Live2.Show();
                    Live1.Show();
                    break;
                case 3:
                    Live3.Show();
                    Live2.Show();
                    Live1.Show();
                    break;
            }
        }

        //MonsterNew, erstellt ein Monster mit den definierten Values, neu
        public void MonstersNew()
        {
            for (int i = 0; i < 24; i++)
            {
                int reihe = i / 8;
                int spalte = i - ((reihe) * 8);

                Monster monster = new Monster(new Point(160 + (spalte * 80), 150 + (reihe * 80)));
                Controls.Add(monster.PictureBox);
                monsters.Add(monster);
            }
        }

        //MonsterDel, löscht alle noch vorhandenen Monster in der Liste "Monster"
        public void MonstersDelete()
        {
            SuspendLayout();
            foreach (Monster monster in monsters)
            {
                Controls.Remove(monster.PictureBox);
            }
            monsters.Clear();
            ResumeLayout();
        }
        public void BulletDelete()
        {
            Controls.Remove(tankBullet.Label);
            tankBullet = null;
        }

        //Ende, führt wiederholt die Aktionen der GameOver-Funktin aus, zudem öffnet sie die HighScore-Liste
        private void End()
        {
            MonstersDelete();
            if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                Connections c = new Connections();

                c.InsertData(Score, Stage, Hits);
            }
            else
            {
                new NetworkFail().Show(this);
            }
            Over = true;
            Live3.Hide();
            Live2.Hide();
            Live1.Hide();
            Label5.Show();
            Bullets.Stop();
            MonstersMove.Stop();
            Random.Stop();
            MonstersAttack.Stop();
            GameOver();
        }


        //GameOver wird nach dem drücken einer belibigen Taste, nach dem Ende des Spiels ausgeführt
        private void GameOver()
        {
            Score = 0;
            Hits = 0;
            Stage = 1;
            LabelScore.Text = Score.ToString();
            LabelStage.Text = Stage.ToString();
            Lives = 3;
            Label2.Hide();
            Label5.Hide();

            Over = false;

            Live1.Show();
            Live2.Show();
            Live3.Show();

            MonstersDelete();
            MonstersNew();

            Random.Start();
            MonstersMove.Start();
            Bullets.Start();
            MonstersAttack.Start();
        }
    }
}
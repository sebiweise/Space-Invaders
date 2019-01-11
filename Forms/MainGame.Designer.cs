namespace Space_Invaders
{
    partial class MainGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        /// 
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainGame));
            this.LabelScore = new System.Windows.Forms.Label();
            this.Bullets = new System.Windows.Forms.Timer(this.components);
            this.Bullet1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MonstersMove = new System.Windows.Forms.Timer(this.components);
            this.Label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Live3 = new System.Windows.Forms.PictureBox();
            this.Live2 = new System.Windows.Forms.PictureBox();
            this.Live1 = new System.Windows.Forms.PictureBox();
            this.LabelStage = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.MonstersAttack = new System.Windows.Forms.Timer(this.components);
            this.Random = new System.Windows.Forms.Timer(this.components);
            this.Label5 = new System.Windows.Forms.Label();
            this.Tank = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Live3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Live2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Live1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tank)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelScore
            // 
            this.LabelScore.AutoSize = true;
            this.LabelScore.Font = new System.Drawing.Font("Impact", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelScore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LabelScore.Location = new System.Drawing.Point(12, 13);
            this.LabelScore.Name = "LabelScore";
            this.LabelScore.Size = new System.Drawing.Size(41, 45);
            this.LabelScore.TabIndex = 3;
            this.LabelScore.Text = "0";
            // 
            // Bullets
            // 
            this.Bullets.Tick += new System.EventHandler(this.Bullets_Tick);
            // 
            // Bullet1
            // 
            this.Bullet1.AutoSize = true;
            this.Bullet1.BackColor = System.Drawing.Color.Transparent;
            this.Bullet1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bullet1.ForeColor = System.Drawing.Color.GreenYellow;
            this.Bullet1.Location = new System.Drawing.Point(479, 524);
            this.Bullet1.Name = "Bullet1";
            this.Bullet1.Size = new System.Drawing.Size(15, 24);
            this.Bullet1.TabIndex = 4;
            this.Bullet1.Text = "|";
            this.Bullet1.Visible = false;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label4.Location = new System.Drawing.Point(-2, 551);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1015, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "=================================================================================" +
    "================================================================================" +
    "=======";
            // 
            // MonstersMove
            // 
            this.MonstersMove.Interval = 300;
            this.MonstersMove.Tick += new System.EventHandler(this.MonstersMove_Tick);
            // 
            // Label7
            // 
            this.Label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label7.AutoSize = true;
            this.Label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label7.Font = new System.Drawing.Font("Impact", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label7.Location = new System.Drawing.Point(183, 226);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(630, 80);
            this.Label7.TabIndex = 3;
            this.Label7.Text = "Press Any Key To Start";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.Live3);
            this.panel2.Controls.Add(this.Live2);
            this.panel2.Controls.Add(this.Live1);
            this.panel2.Controls.Add(this.LabelStage);
            this.panel2.Controls.Add(this.LabelScore);
            this.panel2.Controls.Add(this.Label3);
            this.panel2.Location = new System.Drawing.Point(0, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1012, 85);
            this.panel2.TabIndex = 8;
            // 
            // Live3
            // 
            this.Live3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Live3.BackColor = System.Drawing.Color.Transparent;
            this.Live3.Image = global::Space_Invaders.Properties.Resources.tank;
            this.Live3.Location = new System.Drawing.Point(940, 13);
            this.Live3.Name = "Live3";
            this.Live3.Size = new System.Drawing.Size(65, 47);
            this.Live3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Live3.TabIndex = 13;
            this.Live3.TabStop = false;
            // 
            // Live2
            // 
            this.Live2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Live2.BackColor = System.Drawing.Color.Transparent;
            this.Live2.Image = global::Space_Invaders.Properties.Resources.tank;
            this.Live2.Location = new System.Drawing.Point(873, 13);
            this.Live2.Name = "Live2";
            this.Live2.Size = new System.Drawing.Size(65, 47);
            this.Live2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Live2.TabIndex = 12;
            this.Live2.TabStop = false;
            // 
            // Live1
            // 
            this.Live1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Live1.BackColor = System.Drawing.Color.Transparent;
            this.Live1.Image = global::Space_Invaders.Properties.Resources.tank;
            this.Live1.Location = new System.Drawing.Point(804, 13);
            this.Live1.Name = "Live1";
            this.Live1.Size = new System.Drawing.Size(65, 47);
            this.Live1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Live1.TabIndex = 11;
            this.Live1.TabStop = false;
            // 
            // LabelStage
            // 
            this.LabelStage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LabelStage.AutoSize = true;
            this.LabelStage.Font = new System.Drawing.Font("Impact", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LabelStage.Location = new System.Drawing.Point(445, 13);
            this.LabelStage.Name = "LabelStage";
            this.LabelStage.Size = new System.Drawing.Size(41, 45);
            this.LabelStage.TabIndex = 7;
            this.LabelStage.Text = "0";
            // 
            // Label3
            // 
            this.Label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Impact", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label3.Location = new System.Drawing.Point(700, 10);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(101, 45);
            this.Label3.TabIndex = 3;
            this.Label3.Text = "Lives";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(608, 523);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 10;
            // 
            // Label2
            // 
            this.Label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label2.Font = new System.Drawing.Font("Impact", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label2.Location = new System.Drawing.Point(347, 226);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(281, 80);
            this.Label2.TabIndex = 3;
            this.Label2.Text = "You Won!";
            this.Label2.Visible = false;
            // 
            // MonstersAttack
            // 
            this.MonstersAttack.Interval = 1;
            // 
            // Random
            // 
            this.Random.Interval = 1;
            this.Random.Tick += new System.EventHandler(this.Random_Tick);
            // 
            // Label5
            // 
            this.Label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Impact", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label5.Location = new System.Drawing.Point(317, 364);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(344, 45);
            this.Label5.TabIndex = 7;
            this.Label5.Text = "Press Space to Start";
            this.Label5.Visible = false;
            // 
            // Tank
            // 
            this.Tank.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Tank.BackColor = System.Drawing.Color.Transparent;
            this.Tank.Image = global::Space_Invaders.Properties.Resources.tank;
            this.Tank.Location = new System.Drawing.Point(453, 508);
            this.Tank.Name = "Tank";
            this.Tank.Size = new System.Drawing.Size(65, 47);
            this.Tank.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Tank.TabIndex = 0;
            this.Tank.TabStop = false;
            // 
            // MainGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1008, 567);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Tank);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Bullet1);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.TopMost = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_KeyDown);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Live3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Live2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Live1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tank)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Tank;
        private System.Windows.Forms.Label LabelScore;
        private System.Windows.Forms.Timer Bullets;
        private System.Windows.Forms.Label Bullet1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer MonstersMove;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Label7;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Timer MonstersAttack;
        private System.Windows.Forms.Timer Random;
        private System.Windows.Forms.Label Label5;
        private System.Windows.Forms.Label LabelStage;
        private System.Windows.Forms.PictureBox Live3;
        private System.Windows.Forms.PictureBox Live2;
        private System.Windows.Forms.PictureBox Live1;
    }
}
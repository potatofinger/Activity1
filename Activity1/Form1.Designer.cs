namespace Activity1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            jet = new PictureBox();
            ufo1 = new PictureBox();
            ufo2 = new PictureBox();
            ufo3 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            bullet = new PictureBox();
            Score = new Label();
            bullet2 = new PictureBox();
            explosion = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)jet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ufo1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ufo2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ufo3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bullet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bullet2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)explosion).BeginInit();
            SuspendLayout();
            // 
            // jet
            // 
            jet.BackColor = Color.Transparent;
            jet.Image = (Image)resources.GetObject("jet.Image");
            jet.Location = new Point(29, 212);
            jet.Name = "jet";
            jet.Size = new Size(83, 54);
            jet.SizeMode = PictureBoxSizeMode.StretchImage;
            jet.TabIndex = 0;
            jet.TabStop = false;
            jet.Click += jet_Click;
            // 
            // ufo1
            // 
            ufo1.BackColor = SystemColors.ActiveBorder;
            ufo1.Image = Properties.Resources.ufo1;
            ufo1.Location = new Point(637, 348);
            ufo1.Name = "ufo1";
            ufo1.Size = new Size(86, 53);
            ufo1.SizeMode = PictureBoxSizeMode.StretchImage;
            ufo1.TabIndex = 1;
            ufo1.TabStop = false;
            ufo1.Click += ufo1_Click;
            // 
            // ufo2
            // 
            ufo2.BackColor = Color.Transparent;
            ufo2.Image = Properties.Resources.ufo2;
            ufo2.Location = new Point(528, 210);
            ufo2.Name = "ufo2";
            ufo2.Size = new Size(86, 56);
            ufo2.SizeMode = PictureBoxSizeMode.StretchImage;
            ufo2.TabIndex = 2;
            ufo2.TabStop = false;
            ufo2.Click += ufo2_Click;
            // 
            // ufo3
            // 
            ufo3.BackColor = Color.Transparent;
            ufo3.Image = Properties.Resources.ufo11;
            ufo3.Location = new Point(623, 102);
            ufo3.Name = "ufo3";
            ufo3.Size = new Size(100, 50);
            ufo3.SizeMode = PictureBoxSizeMode.StretchImage;
            ufo3.TabIndex = 3;
            ufo3.TabStop = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // bullet
            // 
            bullet.Image = Properties.Resources.bullet;
            bullet.Location = new Point(130, 439);
            bullet.Name = "bullet";
            bullet.Size = new Size(65, 37);
            bullet.SizeMode = PictureBoxSizeMode.StretchImage;
            bullet.TabIndex = 4;
            bullet.TabStop = false;
            bullet.Click += pictureBox1_Click;
            // 
            // Score
            // 
            Score.AutoSize = true;
            Score.BackColor = SystemColors.ActiveCaptionText;
            Score.Location = new Point(29, 23);
            Score.Name = "Score";
            Score.Size = new Size(36, 15);
            Score.TabIndex = 6;
            Score.Text = "Score";
            Score.Click += label2_Click;
            // 
            // bullet2
            // 
            bullet2.Image = Properties.Resources.bullet;
            bullet2.Location = new Point(219, 439);
            bullet2.Name = "bullet2";
            bullet2.Size = new Size(65, 37);
            bullet2.SizeMode = PictureBoxSizeMode.StretchImage;
            bullet2.TabIndex = 7;
            bullet2.TabStop = false;
            // 
            // explosion
            // 
            explosion.Image = (Image)resources.GetObject("explosion.Image");
            explosion.Location = new Point(302, 428);
            explosion.Name = "explosion";
            explosion.Size = new Size(65, 56);
            explosion.SizeMode = PictureBoxSizeMode.StretchImage;
            explosion.TabIndex = 8;
            explosion.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(784, 519);
            Controls.Add(explosion);
            Controls.Add(bullet2);
            Controls.Add(Score);
            Controls.Add(bullet);
            Controls.Add(ufo3);
            Controls.Add(ufo2);
            Controls.Add(ufo1);
            Controls.Add(jet);
            ForeColor = SystemColors.ControlLightLight;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            KeyDown += keyisdown;
            KeyPress += keyispress;
            KeyUp += keyisup;
            ((System.ComponentModel.ISupportInitialize)jet).EndInit();
            ((System.ComponentModel.ISupportInitialize)ufo1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ufo2).EndInit();
            ((System.ComponentModel.ISupportInitialize)ufo3).EndInit();
            ((System.ComponentModel.ISupportInitialize)bullet).EndInit();
            ((System.ComponentModel.ISupportInitialize)bullet2).EndInit();
            ((System.ComponentModel.ISupportInitialize)explosion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox jet;
        private PictureBox ufo1;
        private PictureBox ufo2;
        private PictureBox ufo3;
        private System.Windows.Forms.Timer timer1;
        private PictureBox bullet;
        private Label Score;
        private PictureBox bullet2;
        private PictureBox explosion;
    }
}

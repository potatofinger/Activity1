using System.Numerics;
using static System.Formats.Asn1.AsnWriter;
using System.Windows.Forms;

namespace Activity1
{
    public partial class Form1 : Form

    {
        int score = 0;
        private bool goup;
        private bool godown;
        bool bulletfired = false;
        int bulletfired1;
        int bulletspeed = 10;

        Random rand = new Random();
        int enemyDirection1 = 3;
        int enemyDirection2 = -3;
        int enemyDirection3 = 2;
        public Form1()
        {
            InitializeComponent();

        }

        private void ufo1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Top n Bottom Jet

            if (goup && jet.Top > 0)
            {
                jet.Top -= 30;
            }
            if (godown && jet.Top + jet.Height < ClientSize.Height)
            {
                jet.Top += 30;
            }

            if (ufo1.Top <= 0 || ufo1.Bottom >= this.ClientSize.Height)
            {
                enemyDirection1 = -enemyDirection1;
            }

            if (ufo2.Top <= 0 || ufo2.Bottom >= this.ClientSize.Height)
            {
                enemyDirection2 = -enemyDirection2;
            }

            if (ufo3.Top <= 0 || ufo3.Bottom >= this.ClientSize.Height)
            {
                enemyDirection3 = -enemyDirection3;
            }

            ufo1.Left -= 10;
            ufo2.Left -= 10;
            ufo3.Left -= 10;

            if (ufo1.Right < 0)
            {
                ufo1.Left = this.ClientSize.Width + rand.Next(50, 200);
                ufo1.Top = rand.Next(20, this.ClientSize.Height - ufo1.Height);
                ufo1.Image = Properties.Resources.ufo1;
            }
            if (ufo2.Right < 0)
            {
                ufo2.Left = this.ClientSize.Width + rand.Next(50, 200);
                ufo2.Top = rand.Next(30, this.ClientSize.Height - ufo2.Height);
                ufo2.Image = Properties.Resources.ufo2;
            }

            if (ufo3.Right < 0)
            {
                ufo3.Left = this.ClientSize.Width + rand.Next(50, 200);
                ufo3.Top = rand.Next(50, this.ClientSize.Height - ufo3.Height);

            }
            if (bullet.Right > this.ClientSize.Width)
            {
                bulletfired = false;
                bullet.Visible = false;
            }
            if (bullet2.Right > this.ClientSize.Width)
            {
                bullet2.Visible = false;
            }


            if (bulletfired)
            {
                bullet.Left += 100;
                if (score > 20)
                {
                    bullet2.Left += 100;
                }
            } 

            Score.Text = score.ToString();
 


            if (bullet.Bounds.IntersectsWith(ufo1.Bounds) || bullet2.Bounds.IntersectsWith(ufo1.Bounds))
            {
                explosion.Left = ufo1.Left;
                explosion.Top = ufo1.Top;
                explosion.Visible = true;

                explosion.Visible = true;
                ufo1.Left = ClientSize.Width + new Random().Next(1, 10);
                bullet.Visible = false;
                bullet2.Visible = false;
                
                bulletfired = false;
                score += 5;
                timer1.Enabled = true;
            }

            if (bullet.Bounds.IntersectsWith(ufo2.Bounds) || bullet2.Bounds.IntersectsWith(ufo2.Bounds))
            {

                explosion.Left = ufo2.Left;
                explosion.Top = ufo2.Top;
                explosion.Visible = true;

                ufo2.Left = ClientSize.Width + new Random().Next(1, 10);
                bullet.Visible = false;
                bullet2.Visible = false;
                bulletfired = false;
             
                score += 10;
                timer1.Enabled = true;
            }

            if (bullet.Bounds.IntersectsWith(ufo3.Bounds) || bullet2.Bounds.IntersectsWith(ufo3.Bounds))
            {

                explosion.Left = ufo3.Left;
                explosion.Top = ufo3.Top;
                explosion.Visible = true;

                ufo3.Left = ClientSize.Width + new Random().Next(1, 10);
                bullet.Visible = false;
                bullet2.Visible = false;
                bulletfired = false;
               
                score += 5;
                timer1.Enabled = true;
            }
        
                if (jet.Bounds.IntersectsWith(ufo1.Bounds) || jet.Bounds.IntersectsWith(ufo2.Bounds) || jet.Bounds.IntersectsWith(ufo3.Bounds))
            {
                gameover();
            }


            Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                goup = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                godown = true;
            }
            if (e.KeyCode == Keys.Space && !bulletfired)
            {
                bulletfired = true;
                bullet.Visible = true;
                bullet.Left = jet.Right;
                bullet.Top = jet.Top + (jet.Height) - (bullet.Height);
            }
            if (score > 20)  
            {
                bulletfired = true;
                bullet2.Visible = true;
                bullet2.Left = jet.Right;
                bullet2.Top = bullet.Top + 20;
            }

        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                goup = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                godown = false;
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ufo2_Click(object sender, EventArgs e)
        {

        }

        private void keyispress(object sender, KeyPressEventArgs e)
        {


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void gameover()
        {

            timer1.Enabled = false;
            explosion.Image = Properties.Resources.jet;
            MessageBox.Show("Game Over!" + "Ufo Defender");
            RestartGame();
        }

        private void RestartGame()
        {
            score = 0;
            Score.Text = "SCORE: " + score;

            jet.Image = Properties.Resources.jet;
            jet.Top = this.ClientSize.Height / 2;

            ufo1.Left = ClientSize.Width + new Random().Next(1, 10);
            ufo1.Top = rand.Next(50, this.ClientSize.Height - ufo1.Height);

            ufo1.Left = ClientSize.Width + new Random().Next(1, 10);
            ufo2.Top = rand.Next(50, this.ClientSize.Height - ufo2.Height);

            ufo1.Left = ClientSize.Width + new Random().Next(1, 10);
            ufo3.Top = rand.Next(50, this.ClientSize.Height - ufo3.Height);

            timer1.Enabled = true;
        }

        private void jet_Click(object sender, EventArgs e)
        {

        }
    }
}

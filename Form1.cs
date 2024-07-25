using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zombie_killer_by_Ayham
{
    public partial class Form1 : Form
    {
        bool goLeft, goRight, goUp, goDown, Gameover;
        string facing = "up";
        int playerhealth = 100;
        int speed = 10;
        int ammo = 10;
        int zombieSpeed = 3;
        int score;
        Random randNum = new Random();
        List<PictureBox> Zombieslist = new List<PictureBox>();


        public Form1()
        {
            InitializeComponent();
            RestartGame();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void MainTimerEvent(object sender, EventArgs e)
        {
            if (playerhealth > 1)
            {
                healthbar.Value = playerhealth;
            }
            else
            {
                Gameover = true;
                player.Image = Properties.Resources.dead;
                gametimer.Stop();
            }
            Ammo.Text = "Ammo : " + ammo;
            kills.Text = "Kills : " + score;
            if (goLeft == true && player.Left > 0)
            {
                player.Left -= speed;
            }
            if (goRight == true && player.Left + player.Width < this.ClientSize.Width)
            {
                player.Left += speed;
            }
            if (goUp == true && player.Top > 49)
            {
                player.Top -= speed;
            }
            if (goDown == true && player.Top + player.Height < this.ClientSize.Height)
            {
                player.Top += speed;
            }

            foreach (Control token in this.Controls)
            {
                if (token is PictureBox && (string)token.Tag == "ammo")
                {
                    if (player.Bounds.IntersectsWith(token.Bounds))
                    {
                        this.Controls.Remove(token);
                        ((PictureBox)token).Dispose();
                        ammo += 5;
                    }
                }


                if (token is PictureBox && (string)token.Tag == "zombie")
                {
                    if (player.Bounds.IntersectsWith(token.Bounds))
                    {
                        playerhealth -= 1;
                    }

                    if (token.Left > player.Left)
                    {
                        token.Left -= zombieSpeed;
                        ((PictureBox)token).Image = Properties.Resources.zleft;
                    }
                    if (token.Left < player.Left)
                    {
                        token.Left += zombieSpeed;
                        ((PictureBox)token).Image = Properties.Resources.zright;
                    }
                    if (token.Top > player.Top)
                    {
                        token.Top -= zombieSpeed;
                        ((PictureBox)token).Image = Properties.Resources.zup;
                    }
                    if (token.Top < player.Top)
                    {
                        token.Top += zombieSpeed;
                        ((PictureBox)token).Image = Properties.Resources.zdown;
                    }

                }
                foreach (Control k in this.Controls)
                {
                    if (k is PictureBox && (string)k.Tag == "bullet" && token is PictureBox && (string)token.Tag == "zombie")
                    {
                        if (token.Bounds.IntersectsWith(k.Bounds))
                        {
                            score++;
                            this.Controls.Remove(k);
                            ((PictureBox)k).Dispose();
                            this.Controls.Remove(token);
                            ((PictureBox)token).Dispose();

                            Zombieslist.Remove((PictureBox)token);
                            makezombize();
                        }

                    }
                }

               /* if (playerhealth == 50)
                {
                    drophealth();
                }

                foreach (Control token1 in this.Controls)
                {
                    if (token1 is PictureBox && (string)token.Tag == "health")
                    {
                        if (player.Bounds.IntersectsWith(token1.Bounds))
                        {

                            playerhealth = 100;
                            this.Controls.Remove(token1);
                            ((PictureBox)token1).Dispose();
                        }
                    }
                }*/




            }
        }

        private void KeyisDown(object sender, KeyEventArgs e)
        {
            if (Gameover == true)
            {
                return;
            }
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
                facing = "left";
                player.Image = Properties.Resources.left;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
                facing = "right";
                player.Image = Properties.Resources.right;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = true;
                facing = "up";
                player.Image = Properties.Resources.up;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = true;
                facing = "down";
                player.Image = Properties.Resources.down;
            }



        }

        private void KeyisUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;

            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;

            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = false;

            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = false;

            }

            if (e.KeyCode == Keys.Space && ammo > 0 && Gameover == false)
            {
                ammo--;
                shootBullet(facing);
                if (ammo < 1)
                {
                    dropammo();
                }
            }
            if (e.KeyCode == Keys.Enter)
            {
                RestartGame();
            }



        }
        private void shootBullet(string direction)
        {
            Bullets shootbullet = new Bullets();
            shootbullet.direction = direction;
            shootbullet.bulletleft = player.Left + (player.Width / 2);
            shootbullet.bullettop = player.Top + (player.Height / 2);
            shootbullet.makebullet(this);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void makezombize()
        {
            PictureBox zombie = new PictureBox();
            zombie.Tag = "zombie";
            zombie.Image = Properties.Resources.zdown;
            zombie.Left = randNum.Next(0, 900);
            zombie.Top = randNum.Next(0, 800);
            zombie.SizeMode = PictureBoxSizeMode.AutoSize;
            Zombieslist.Add(zombie);
            this.Controls.Add(zombie);
            player.BringToFront();



        }
        private void dropammo()
        {
            PictureBox ammo = new PictureBox();
            ammo.Image = Properties.Resources.ammo_Image;
            ammo.SizeMode = PictureBoxSizeMode.AutoSize;
            ammo.Tag = "ammo";
            ammo.Left = randNum.Next(10, this.ClientSize.Width - ammo.Width);
            ammo.Top = randNum.Next(60, this.ClientSize.Height - ammo.Height);
            this.Controls.Add(ammo);
            ammo.BringToFront();
            player.BringToFront();


        }
       /* private void drophealth()
        {
            PictureBox health = new PictureBox();
            health.Image = Properties.Resources.heart3;
            health.SizeMode = PictureBoxSizeMode.AutoSize;
            health.Tag = "health";
            health.Left = randNum.Next(10, this.ClientSize.Width - health.Width);
            health.Top = randNum.Next(60, this.ClientSize.Height - health.Height);
            this.Controls.Add(health);
            health.BringToFront();
            player.BringToFront();

        }*/
        private void RestartGame()
        {
            player.Image = Properties.Resources.up;
            foreach (PictureBox i in Zombieslist)
            {
                this.Controls.Remove(i);
            }
            Zombieslist.Clear();
            for (int i = 0; i < 3; i++)
            {
                makezombize();
            }
            goUp = false;
            goDown = false;
            goLeft = false;
            goRight = false;
            Gameover = false;
            playerhealth = 100;
            score = 0;
            ammo = 10;

            gametimer.Start();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace zombie_killer_by_Ayham
{
    class Bullets
    {
        public string direction;
        public int bulletleft;
        public int bullettop;

        private int speed = 20;
        private PictureBox bullet = new PictureBox();
        private Timer bullettimer = new Timer();

        public void makebullet(Form form)
        {
            bullet.BackColor = Color.BurlyWood;
            bullet.Size = new Size(10, 10);
            bullet.Tag = "bullet";
            bullet.Left = bulletleft;
            bullet.Top = bullettop;
            bullet.BringToFront();

            form.Controls.Add(bullet);

            bullettimer.Interval = speed;

            bullettimer.Tick += new EventHandler(bullettimeEvent);
            bullettimer.Start();

        }

        private void bullettimeEvent(object sender, EventArgs e)
        {
            if (direction == "left")
            {
                bullet.Left -= speed;
            }
            if (direction == "right")
            {
                bullet.Left += speed;
            }
            if (direction == "up")
            {
                bullet.Top -= speed;
            }
            if (direction == "down")
            {
                bullet.Top += speed;
            }
            if (bullet.Left < 10 || bullet.Left > 860 || bullet.Top < 10 || bullet.Top > 600)
            {
                bullettimer.Stop();
                bullettimer.Dispose();
                bullet.Dispose();
                bullettimer = null;
                bullet = null;
            }
        }


    }
}

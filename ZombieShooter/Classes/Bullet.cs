using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Windows.Forms;

namespace ZombieShooter
{
    internal class Bullet
    {
        public double BulletDamage;
        public string direction;
        public int bulletLeft;
        public int bulletTop;

        private int speed;
        private PictureBox bullet = new PictureBox();
        private System.Windows.Forms.Timer bulletTimer = new System.Windows.Forms.Timer();

        public Bullet(double damage, string dir, int left, int top)
        {
            BulletDamage = damage;
            direction = dir;
            bulletLeft = left;
            bulletTop = top;
        }
        public void MakeBullet(Form form, Player1 player)
        {
            if (player.performanceMode == true)
            {
                bullet.BackColor = Color.Transparent;
                bullet.Size = new Size(400, 5);
                speed = 70;
            }
            else
            {
                bullet.BackColor = Color.Yellow;
                bullet.Size = new Size(5, 5);
                speed = 40;
            }

            bullet.Tag = "bullet";
            bullet.Left = bulletLeft;
            bullet.Top = bulletTop;

            form.Controls.Add(bullet);

            if (player.performanceMode == false)
            {
                bullet.BringToFront();

            }

            bulletTimer.Interval = speed;
            bulletTimer.Tick += new EventHandler(BulletTimerEvent);
            bulletTimer.Start();
        }

        private void BulletTimerEvent(object sender, EventArgs e)
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

            if (bullet.Left < 10 || bullet.Left > 1580 || bullet.Top < 10 || bullet.Top > 880)
            {
                bulletTimer.Stop();
                bulletTimer.Dispose();
                bullet.Dispose();
                bulletTimer = null;
                bullet = null;
            }
        }
    }
}

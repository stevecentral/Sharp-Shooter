using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CSharpShooter_ST.GameObjects
{
    public abstract class Weapon
    {
        // weapon attributes
        public Picture pic;
        public PointF location;
        public bool onGround = false;

        // weapon properties
        public float bulletSpeed;
        public int fireDelay;
        public float bsd; //bullet start distance
        public float facingAngle;
        public int tsls = 0; //time since last shot
        public int radius;

        public Weapon(string image, PointF location)
        {
            this.pic = new Picture(image, location, 1, 1);
            this.location = location;
            radius = pic.bitmap.Width / 2;
        }

        public Weapon(string image, PointF location, int frameCount, int frameTime)
        {
            this.pic = new Picture(image, location, frameCount, frameTime);
            this.location = location;
            radius = pic.bitmap.Width / 2;
        }

        public void Update(int time)
        {
            tsls += time;

            if (this.onGround && this.isTouching(MainForm.player1))
            {
                this.onGround = false;
                MainForm.weaponList.Remove(this);
                MainForm.player1.currentWeapon = this;
            }
        }

        public void Draw(Graphics g)
        {
            pic.angle = facingAngle;
            pic.location.X = location.X - MainForm.vos.X;
            pic.location.Y = location.Y - MainForm.vos.Y;
            pic.Draw(g);
        }

        public void Fire(Soldier s)
        {
            if (tsls < fireDelay)
                return;

            tsls = 0;

            float xComponent = (float)Math.Cos(facingAngle / 180f * Math.PI);
            float yComponent = -(float)Math.Sin(facingAngle / 180f * Math.PI);

            Bullet bullet = createBullet(s);
            bullet.location.X += xComponent * bsd;
            bullet.location.Y += yComponent * bsd;
            bullet.velocity.X = xComponent * bulletSpeed;
            bullet.velocity.Y = yComponent * bulletSpeed;
        }

        public bool isTouching(Soldier s)
        {
            double distance = Math.Sqrt((s.location.X - this.location.X) *
                                        (s.location.X - this.location.X) +
                                        (s.location.Y - this.location.Y) *
                                        (s.location.Y - this.location.Y));

            return distance < this.radius + s.radius;

        }

        public abstract Bullet createBullet(Soldier s);
    }
}

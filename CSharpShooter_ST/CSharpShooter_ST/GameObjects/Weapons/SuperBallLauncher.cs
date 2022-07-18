using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CSharpShooter_ST.GameObjects
{
    class SuperBallLauncher : Weapon
    {

        public SuperBallLauncher(PointF location) : base("Images/SuperBallLauncher.png", location)
        {
            this.bulletSpeed = 15f;
            this.bsd = 40f;
            this.fireDelay = 600;
        }

        public override Bullet createBullet(Soldier s)
        {
            Bullet b = new Bullet("Images/SuperBall.png", s, s.location);
            b.life = 0.3f;
            b.damage = 5;
            return b;
        }
    }
}

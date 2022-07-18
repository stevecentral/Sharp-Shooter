using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CSharpShooter_ST.GameObjects
{
    class SniperRifle : Weapon
    {

        public SniperRifle(PointF location) : base("Images/SniperRifle.png", location)
        {
            this.bulletSpeed = 30f;
            this.bsd = 50f;
            this.fireDelay = 1000;
        }

        public override Bullet createBullet(Soldier s)
        {
            Bullet b = new Bullet("Images/SniperBullet.png", s, s.location);
            b.life = 3.0f;
            b.damage = 5;
            return b;
        }
    }
}

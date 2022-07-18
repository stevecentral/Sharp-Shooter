using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CSharpShooter_ST.GameObjects
{
    class AR : Weapon
    {

        public AR(PointF location) : base("Images/RapidGun.png", location)
        {
            this.bulletSpeed = 25f;
            this.bsd = 40f;
            this.fireDelay = 300;
        }

        public override Bullet createBullet(Soldier s)
        {
            Bullet b = new Bullet("Images/Bullet2.png", s, s.location);
            b.life = 1.0f;
            b.damage = 1;
            return b;
        }
    }
}

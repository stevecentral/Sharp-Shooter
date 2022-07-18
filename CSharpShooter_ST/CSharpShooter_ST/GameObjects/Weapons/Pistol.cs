using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CSharpShooter_ST.GameObjects
{
    class Pistol : Weapon
    {

        public Pistol(PointF location) : base("Images/Pistol.png", location)
        {
            this.bulletSpeed = 15f;
            this.bsd = 40f;
            this.fireDelay = 600;
        }

        public override Bullet createBullet(Soldier s)
        {
            Bullet b = new Bullet("Images/Bullet3.png", s, s.location);
            b.life = 1.0f;
            b.damage = 2;
            return b;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CSharpShooter_ST.GameObjects
{
    class SRG : Weapon
    {

        public SRG(PointF location) : base("Images/AnimatedSuperRapidGun.png", location, 12, 100)
        {
            this.bulletSpeed = 25f;
            this.bsd = 40f;
            this.fireDelay = 150;
        }

        public override Bullet createBullet(Soldier s)
        {
            Bullet b = new Bullet("Images/Bullet_1.png", s, s.location);
            b.life = 1.0f;
            b.damage = 1;
            return b;
        }
    }
}

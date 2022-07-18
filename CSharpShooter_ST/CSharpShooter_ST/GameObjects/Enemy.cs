using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CSharpShooter_ST.GameObjects
{

    public class Enemy : Soldier
    {
        int dcc = 0;
        int ndc = 0;

        public Enemy(PointF location) : base("Images/Enemy3.png", location)
        {
            MainForm.enemyList.Add(this);
            isFiring = true;
            moveSpeed = 3;
            walkDirc = 1;
            this.currentWeapon = new Pistol(this.location);
            Random r = new Random((int)location.X);
            ndc = r.Next(500) + 2000;
        }

        public override void Update(int time)
        {
            if (this.killed) MainForm.enemyList.Remove(this);

            base.Update(time);

            dcc += time;

            if (dcc >= ndc)
            {
                Random r = new Random();
                facingAngle = r.Next(360);
                dcc = 0;
                ndc = r.Next(500) + 2000;
            }
        }
    }
}

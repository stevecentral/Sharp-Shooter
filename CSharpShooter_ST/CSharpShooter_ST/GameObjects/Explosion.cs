using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CSharpShooter_ST.GameObjects
{
    public class Explosion
    {
        public PointF location;
        public Picture pic;
        public int counter = 300;

        public Explosion(PointF location)
        {
            this.location = location;
            pic = new Picture("Images/Explode.png", location, 6, 40);

            MainForm.explosionList.Add(this);
        }

        public void Draw(Graphics g)
        {
            pic.location.X = location.X - MainForm.vos.X;
            pic.location.Y = location.Y - MainForm.vos.Y;

            pic.Draw(g);
        }

        public void Update(int time)
        {
            counter -= time;

            if (counter <= 0)
            {
                MainForm.explosionList.Remove(this);
                return;
            }

            pic.Update(time);
        }
    }
}

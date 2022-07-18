using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpShooter_ST.GameObjects
{
    public class Bullet
    {
        public PointF location;
        public PointF velocity;
        public Picture pic;
        public float life = 1.0f;

        public int radius;
        public Soldier parent;
        public int damage = 1;

        public Bullet(string image, Soldier s, PointF location)
        {
            this.parent = s;
            this.location = location;
            pic = new Picture(image, this.location, 4, 25);
            velocity = new PointF();
            MainForm.bulletList.Add(this);
            radius = pic.bitmap.Width / 2;
        }

        public virtual void Draw(Graphics g)
        {
            pic.location.X = location.X - MainForm.vos.X;
            pic.location.Y = location.Y - MainForm.vos.Y;

            pic.Draw(g);
        }

        public void Update(int time)
        {
            Move();
            pic.Update(time);

            life -= (float)time / 1000f;
            if (life <= 0)
                MainForm.bulletList.Remove(this);

            foreach (Wall w in MainForm.wallList)
            {
                if (this.isTouchingWall(w))
                {
                    this.backUpPosition();

                    PointF normal = w.normalAtNearestPoint(this.location);
                    this.bounceFrom(normal);
                }
            }

            if (parent == MainForm.player1)
            {
                for (int i = 0; i < MainForm.enemyList.Count; i++)
                {
                    if (this.isTouching(MainForm.enemyList[i]))
                    {
                        MainForm.enemyList[i].takeDamage(damage);
                        MainForm.bulletList.Remove(this);
                    }
                }
            }

            if (this.isTouching(MainForm.player1) && !MainForm.player1.killed)
            {
                MainForm.player1.takeDamage(damage);
                MainForm.bulletList.Remove(this);
            }
        }

        public virtual void Move()
        {
            location.X += velocity.X;
            location.Y += velocity.Y;
        }

        public bool isTouching(Soldier s)
        {
            double distance = Math.Sqrt((s.location.X - this.location.X) *
                                        (s.location.X - this.location.X) +
                                        (s.location.Y - this.location.Y) *
                                        (s.location.Y - this.location.Y));

            return distance < this.radius + s.radius;

        }

        public bool isTouchingWall(Wall w)
        {
            //First we need the neaerestPoint on the wall, which takes some work, so we have a seperate function for it
            PointF nearestPoint = w.pointNearestTo(this.location);

            //Now see if the nearestPoint is touching the wall using a little bit of simple trig (pythagorean)
            float distance = (float)Math.Sqrt((nearestPoint.X - this.location.X) *
                                        (nearestPoint.X - this.location.X) +
                                        (nearestPoint.Y - this.location.Y) *
                                        (nearestPoint.Y - this.location.Y));

            //If the distance is less than the radius that point is in the circle, so set the touchPoint to the nearestPoint and return true
            //To indicate that we found an overlap. Else just return false

            return distance < this.radius ? true : false;
        }

        public void backUpPosition()
        {
            this.location.X -= this.velocity.X;
            this.location.Y -= this.velocity.Y;
        }

        public void bounceFrom(PointF normal)
        {
            PointF r;

            float b = (velocity.X * normal.X + velocity.Y * normal.Y);

            b *= 2;

            r = new PointF(this.velocity.X - normal.X * b, this.velocity.Y - normal.Y * b);

            this.velocity.X = r.X;
            this.velocity.Y = r.Y;
        }
    }
}

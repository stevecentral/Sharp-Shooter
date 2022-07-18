using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CSharpShooter_ST.GameObjects
{
    public class Soldier
    {
        public Picture pic;
        public PointF location;
        public PointF velocity;
        public float facingAngle = 0f;
        public float turnDirc = 0f;
        public int walkDirc = 0;
        public int moveSpeed = 10;
        public bool isFiring = false;
        public float bulletSpeed = 15f;
        public int fireDelay = 0;
        public int timeSinceLastShot = 0;
        public float bulletStartDistance = 30f;
        public int radius;
        public int hp = 5;
        public bool killed = false;
        public bool hitFlicker = false;
        public int hitFlickCounter = 0;
        public bool ghostmode = false;

        public Weapon currentWeapon;

        public Soldier(String image, PointF location)
        {
            pic = new Picture(image, location, 4, 60);
            this.location = location;
            velocity = new PointF();

            Random r = new Random((int)DateTime.Now.Ticks);
            facingAngle = r.Next(360);
            radius = pic.bitmap.Width / 2;
        }

        public void Draw(Graphics g)
        {
            if (this.killed)
                return;

            pic.angle = facingAngle;

            if (!hitFlicker)
            {
                pic.location.X = location.X - MainForm.vos.X;
                pic.location.Y = location.Y - MainForm.vos.Y;
                pic.Draw(g);
                currentWeapon.Draw(g);
            }
        }

        public virtual void Update(int time)
        {
            if (hp <= 0)
            {
                Explosion e = new Explosion(this.location);
                killed = true;
                return;
            }

            if (hitFlickCounter > 0)
            {
                hitFlickCounter--;
                hitFlicker = !hitFlicker;
            }
            else
            {
                hitFlicker = false;
            }

            facingAngle += ((float)(time)) * turnDirc;
            velocity.X = (float)Math.Cos(facingAngle / 180f * Math.PI) * walkDirc * moveSpeed;
            velocity.Y = -(float)Math.Sin(facingAngle / 180f * Math.PI) * walkDirc * moveSpeed;
            Move();
            updateWeapon(time);
            if (velocity.X != 0 || velocity.Y != 0) pic.Update(time);

            if (isFiring)
                currentWeapon.Fire(this);

            if (!ghostmode)
                foreach (Wall w in MainForm.wallList)
                {
                    PointF touchPoint = new PointF();
                    if (this.isTouchingWall(w, ref touchPoint))
                    {
                        pushFrom(touchPoint);
                    }
                }

            timeSinceLastShot += time;

        }

        public void Move()
        {
            location.X += velocity.X;
            location.Y += velocity.Y;
        }

        public void takeDamage(int damage)
        {
            hp -= damage;
            hitFlickCounter = 4;
        }

        public bool isTouchingWall(Wall w, ref PointF touchPoint)
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
            if (distance < this.radius)
            {
                touchPoint = nearestPoint;
                return true;
            }
            else
                return false;
        }

        public void pushFrom(PointF p)
        {
            float actualDistance = (float)Math.Sqrt((p.X - this.location.X) *
                                        (p.X - this.location.X) +
                                        (p.Y - this.location.Y) *
                                        (p.Y - this.location.Y));

            if (actualDistance == 0)
                return;
            float desiredDistance = this.radius + 1;

            float proportion = desiredDistance / actualDistance;

            PointF move = new PointF(this.location.X - p.X, this.location.Y - p.Y);
            move.X *= proportion;
            move.Y *= proportion;

            this.location.X = p.X + move.X;
            this.location.Y = p.Y + move.Y;
        }

        public void updateWeapon(int time)
        {
            float xoffset = (float)Math.Cos(this.facingAngle / 180f * Math.PI) * 32f;
            float yoffset = -(float)Math.Sin(this.facingAngle / 180f * Math.PI) * 32f;

            currentWeapon.location.X = location.X + xoffset;
            currentWeapon.location.Y = location.Y + yoffset;

            currentWeapon.facingAngle = this.facingAngle;
            currentWeapon.tsls += time;
        }
    }
}

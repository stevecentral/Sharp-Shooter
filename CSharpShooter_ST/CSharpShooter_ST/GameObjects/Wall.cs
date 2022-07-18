using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace CSharpShooter_ST.GameObjects
{
    public class Wall
    {

        public int left, top, width, height;
        public Bitmap image;

        public Wall(String colour, int left, int top, int width, int height)
        {
            image = new Bitmap("Images/" + colour + "Box.png");
            this.left = left;
            this.top = top;
            this.width = width;
            this.height = height;

            MainForm.wallList.Add(this);
        }

        public void Draw(Graphics g)
        {
            g.Transform = new Matrix();
            g.DrawImage(image, new Rectangle(left - MainForm.vos.X, top - MainForm.vos.Y, width, height));
        }

        public PointF pointNearestTo(PointF p)
        {
            //Initialize a new pointF called nearestPoint
            PointF nearestPoint = new PointF();

            //Check if the lest edge of this wall is to the right of the point 'p'
            //if it is, then the nearestPoint's X coordinate must be the left edge of this wall
            if (this.left > p.X)
                nearestPoint.X = this.left;

            //else if the right edge of this wall is to the left of the point 'p'
            //the nearestPoint's X coord must be the right edge of this wall
            else if (this.left + this.width < p.X)
                nearestPoint.X = this.left + this.width;

            //If it is not to the left and not to the right, it MUST be inside the wall. So we'll set the nearestPoint's X coord to the p.X's coord
            else
                nearestPoint.X = p.X;

            if (this.top > p.Y)
                nearestPoint.Y = this.top;
            else if (this.top + this.height < p.Y)
                nearestPoint.Y = this.top + this.height;
            else
                nearestPoint.Y = p.Y;

            //return nearestPoint
            return nearestPoint;
        }

        public PointF normalAtNearestPoint(PointF p)
        {
            PointF nearestPoint = this.pointNearestTo(p);

            PointF normal = new PointF();
            normal.X = p.X - nearestPoint.X;
            normal.Y = p.Y - nearestPoint.Y;

            if (normal.X == 0 && normal.Y == 0)
                return normal;

            float factor = 1f / (float)Math.Sqrt(normal.X * normal.X + normal.Y * normal.Y);

            normal.X *= factor;
            normal.Y *= factor;

            return normal;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;

namespace CSharpShooter_ST
{
    public class Picture
    {
        // Picture Attributes
        public Bitmap bitmap;
        public PointF location;
        public float angle = 0f;
        public PointF offset;

        // Animation Attributes
        public int frame = 0; // the current frame
        public int frameCount, frameTime; // total number of frames and number of 'tricks' per frame
        public int animationCounter = 0; // keep track of time since we changed frames

        public Picture(string fileName, PointF location, int frameCount, int frameTime)
        {
            this.frameCount = frameCount;
            this.frameTime = frameTime;
            bitmap = new Bitmap(fileName);
            this.location = location;
            offset = new PointF(bitmap.Width / 2f, bitmap.Height / frameCount / 2f);
        }

        public void Draw(Graphics g)
        {
            //our pictures need to be centered about the origin
            Point drawLocation = new Point((int)(location.X - offset.X), (int)(location.Y - offset.Y));

            //Create a matix
            Matrix m = new Matrix();
            //rotate by a given angle and around the centre location of the image
            m.RotateAt(-angle, location);
            //set the drawing transformation to this matrix
            g.Transform = m;
            g.DrawImage(bitmap,
                new Rectangle(drawLocation.X, drawLocation.Y,
                bitmap.Width, bitmap.Height / this.frameCount),
                new Rectangle(0, frame * bitmap.Height / this.frameCount,
                bitmap.Width, bitmap.Height / this.frameCount),
                GraphicsUnit.Pixel
                );
        }

        public void Update(int time)
        {
            animationCounter += time;

            if (animationCounter >= this.frameTime)
            {
                this.frame++;
                if (this.frame >= this.frameCount) frame = 0;
                animationCounter = 0;
            }
        }
    }
}

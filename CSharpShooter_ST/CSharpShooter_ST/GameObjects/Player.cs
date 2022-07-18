using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpShooter_ST.GameObjects
{
    public class Player : Soldier
    {
        public Player(PointF location) : base("Images/Player.png", location)
        {
            this.currentWeapon = new AR(this.location);
        }

        public void KeyDown(Object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
                turnDirc = 0.5f;

            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
                turnDirc = -0.5f;

            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
                walkDirc = 1;

            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
                walkDirc = -1;

            if (e.KeyCode == Keys.Space)
                isFiring = true;
        }

        public void KeyUp(Object sender, KeyEventArgs e) // using System.Windows.Forms;
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
                turnDirc = 0;

            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
                turnDirc = 0;

            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
                walkDirc = 0;

            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
                walkDirc = 0;

            if (e.KeyCode == Keys.Space)
                isFiring = false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSharpShooter_ST.GameObjects;

namespace CSharpShooter_ST
{
    public partial class MainForm : Form
    {
        // background
        public static Image image;
        public static TextureBrush brush;

        // game vars
        public static Player player1;
        public static List<Bullet> bulletList;
        public static List<Enemy> enemyList;
        public static List<Wall> wallList;
        public static List<Explosion> explosionList;
        public static List<Weapon> weaponList;
        //public static List<Key> keyList;

        // control vars
        public static bool rapidfireon = false;
        public static bool playerhacked = false;
        public static bool ghostmodeon = false;
        public static bool speedon = false;

        // graphics vars
        Graphics windowsGraphics;
        Graphics onScreenGraphics;
        Bitmap screen;
        public static Point vos; // view offset

        // screen vars
        public Picture gameOverScreen;
        public Picture victoryScreen;

        // level vars
        public static String currentLevel = "";

        public MainForm()
        {
            this.StartPosition = FormStartPosition.CenterScreen;

            InitializeComponent();
            String[] elems = System.IO.Directory.GetFiles("Levels/");
            foreach (String elem in elems)
            {
                levelSelectBox.Items.Add(elem.Replace("Levels/", "").Replace(".txt", ""));
            }

            windowsGraphics = this.CreateGraphics();
            screen = new Bitmap(this.Width, this.Height);
            onScreenGraphics = Graphics.FromImage(screen);
            gameOverScreen = new Picture("Images/GameOver.png", new PointF(this.Width / 2, this.Height / 2), 1, 1);
            victoryScreen = new Picture("Images/Victory.png", new PointF(this.Width / 2, this.Height / 2), 1, 1);

            //set up the window to be called when the window
            this.Paint += new PaintEventHandler(DrawGame);
            GameTimer.Enabled = false;
        }

        void Init()
        {
            image = new Bitmap("Images/Ground.png");
            brush = new TextureBrush(image);
            brush.WrapMode = System.Drawing.Drawing2D.WrapMode.TileFlipX;
            if (levelSelectBox.SelectedIndex == 0)
                Level.loadLevel("level2");
            else
                Level.loadLevel(currentLevel);
            Level.loadLevel("level2");
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(player1.KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(player1.KeyUp);
            GameTimer.Enabled = true;
        }

        public void DrawGame(object sender, PaintEventArgs e)
        {
            if (!GameTimer.Enabled)
                return;
            onScreenGraphics.Clear(Color.Black);
            onScreenGraphics.FillRectangle(brush, new Rectangle(0, 0, this.Width, this.Height));

            player1.Draw(onScreenGraphics);

            foreach (Bullet b in bulletList)
            {
                b.Draw(onScreenGraphics);
            }

            foreach (Enemy b in enemyList)
            {
                b.Draw(onScreenGraphics);
            }

            foreach (Wall w in wallList)
            {
                w.Draw(onScreenGraphics);
            }

            foreach (Explosion w in explosionList)
            {
                w.Draw(onScreenGraphics);
            }

            foreach (Weapon w in weaponList)
            {
                w.Draw(onScreenGraphics);
            }

            if (player1.killed) gameOverScreen.Draw(onScreenGraphics);

            if (enemyList.Count == 0) victoryScreen.Draw(onScreenGraphics);

            windowsGraphics.DrawImage(screen, new Point(0, 0));
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            if (!player1.killed && enemyList.Count != 0)
            {
                player1.Update(GameTimer.Interval);

                vos.X = (int)player1.location.X - this.Width / 2;
                vos.Y = (int)player1.location.Y - this.Height / 2;

                for (int i = 0; i < bulletList.Count; i++)
                {
                    bulletList[i].Update(GameTimer.Interval);
                }

                for (int i = 0; i < enemyList.Count; i++)
                {
                    enemyList[i].Update(GameTimer.Interval);
                }

                for (int i = 0; i < explosionList.Count; i++)
                {
                    explosionList[i].Update(GameTimer.Interval);
                }

                for (int i = 0; i < weaponList.Count; i++)
                {
                    weaponList[i].Update(GameTimer.Interval);
                }

                OnPaint(new PaintEventArgs(windowsGraphics, new Rectangle(0, 0, this.Width, this.Height)));
            }
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Init();
        }

        private void aRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            player1.currentWeapon = new AR(player1.location);
            playerhacked = true;
        }

        private void pistolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            player1.currentWeapon = new Pistol(player1.location);
            playerhacked = true;
        }

        private void sniperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            player1.currentWeapon = new SniperRifle(player1.location);
            playerhacked = true;
        }

        private void ballLauncherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            player1.currentWeapon = new SuperBallLauncher(player1.location);
            playerhacked = true;
        }

        private void superRapidGunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            player1.currentWeapon = new SRG(player1.location);
            playerhacked = true;
        }

        private void ghostModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!ghostmodeon)
            {
                ghostModeToolStripMenuItem.Text = "ghost mode Off";
                player1.ghostmode = true;
                ghostmodeon = true;
            }
            else
            {
                ghostModeToolStripMenuItem.Text = "ghost mode On";
                player1.ghostmode = false;
                ghostmodeon = false;
            }
            playerhacked = true;
        }

        private void rapidGunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!rapidfireon)
            {
                rapidFireToolStripMenuItem.Text = "Rapid Fire Off";
                player1.currentWeapon.fireDelay = 600;
                rapidfireon = true;
            }
            else
            {
                rapidFireToolStripMenuItem.Text = "Rapid Fire On";
                player1.currentWeapon.fireDelay = 1;
                rapidfireon = false;
            }
            playerhacked = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void speedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!speedon)
            {
                speedToolStripMenuItem.Text = "Speed Off";
                player1.moveSpeed *= 2;
                speedon = true;
            }
            else
            {
                rapidFireToolStripMenuItem.Text = "Speed On";
                player1.moveSpeed *= 2;
                speedon = false;
            }
            playerhacked = true;
        }

        private void playLabel_Click(object sender, EventArgs e)
        {
            title.Hide();
            playLabel.Hide();
            exitLabel.Hide();
            menuStrip1.Hide();
            currentLevel = levelSelectBox.SelectedItem.ToString();
            levelSelectBox.Hide();
            this.levelSelectBox.Dispose();
            Init();
        }

        private void exitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

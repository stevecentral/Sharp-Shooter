namespace CSharpShooter_ST
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.weponSelectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pistolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sniperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ballLauncherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.superRapidGunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ghostModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rapidFireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.title = new System.Windows.Forms.PictureBox();
            this.playLabel = new System.Windows.Forms.Label();
            this.exitLabel = new System.Windows.Forms.Label();
            this.levelSelectBox = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.title)).BeginInit();
            this.SuspendLayout();
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 50;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.devToolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(586, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.optionsToolStripMenuItem.ForeColor = System.Drawing.Color.Yellow;
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.resetToolStripMenuItem.ForeColor = System.Drawing.Color.Yellow;
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.resetToolStripMenuItem.ShowShortcutKeys = false;
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.Yellow;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.exitToolStripMenuItem.ShowShortcutKeys = false;
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // devToolsToolStripMenuItem
            // 
            this.devToolsToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.devToolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.weponSelectionToolStripMenuItem,
            this.ghostModeToolStripMenuItem,
            this.rapidFireToolStripMenuItem,
            this.speedToolStripMenuItem});
            this.devToolsToolStripMenuItem.ForeColor = System.Drawing.Color.Yellow;
            this.devToolsToolStripMenuItem.Name = "devToolsToolStripMenuItem";
            this.devToolsToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.devToolsToolStripMenuItem.Text = "Dev Tools";
            // 
            // weponSelectionToolStripMenuItem
            // 
            this.weponSelectionToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.weponSelectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aRToolStripMenuItem,
            this.pistolToolStripMenuItem,
            this.sniperToolStripMenuItem,
            this.ballLauncherToolStripMenuItem,
            this.superRapidGunToolStripMenuItem});
            this.weponSelectionToolStripMenuItem.ForeColor = System.Drawing.Color.Yellow;
            this.weponSelectionToolStripMenuItem.Name = "weponSelectionToolStripMenuItem";
            this.weponSelectionToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.weponSelectionToolStripMenuItem.Text = "Wepon Selection";
            // 
            // aRToolStripMenuItem
            // 
            this.aRToolStripMenuItem.ForeColor = System.Drawing.Color.Yellow;
            this.aRToolStripMenuItem.Name = "aRToolStripMenuItem";
            this.aRToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.aRToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.aRToolStripMenuItem.Text = "AR";
            this.aRToolStripMenuItem.Click += new System.EventHandler(this.aRToolStripMenuItem_Click);
            // 
            // pistolToolStripMenuItem
            // 
            this.pistolToolStripMenuItem.ForeColor = System.Drawing.Color.Yellow;
            this.pistolToolStripMenuItem.Name = "pistolToolStripMenuItem";
            this.pistolToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.pistolToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.pistolToolStripMenuItem.Text = "Pistol";
            this.pistolToolStripMenuItem.Click += new System.EventHandler(this.pistolToolStripMenuItem_Click);
            // 
            // sniperToolStripMenuItem
            // 
            this.sniperToolStripMenuItem.ForeColor = System.Drawing.Color.Yellow;
            this.sniperToolStripMenuItem.Name = "sniperToolStripMenuItem";
            this.sniperToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D3)));
            this.sniperToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.sniperToolStripMenuItem.Text = "Sniper";
            this.sniperToolStripMenuItem.Click += new System.EventHandler(this.sniperToolStripMenuItem_Click);
            // 
            // ballLauncherToolStripMenuItem
            // 
            this.ballLauncherToolStripMenuItem.ForeColor = System.Drawing.Color.Yellow;
            this.ballLauncherToolStripMenuItem.Name = "ballLauncherToolStripMenuItem";
            this.ballLauncherToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D4)));
            this.ballLauncherToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.ballLauncherToolStripMenuItem.Text = "Ball Launcher";
            this.ballLauncherToolStripMenuItem.Click += new System.EventHandler(this.ballLauncherToolStripMenuItem_Click);
            // 
            // superRapidGunToolStripMenuItem
            // 
            this.superRapidGunToolStripMenuItem.ForeColor = System.Drawing.Color.Yellow;
            this.superRapidGunToolStripMenuItem.Name = "superRapidGunToolStripMenuItem";
            this.superRapidGunToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D5)));
            this.superRapidGunToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.superRapidGunToolStripMenuItem.Text = "Super Rapid Gun";
            this.superRapidGunToolStripMenuItem.Click += new System.EventHandler(this.superRapidGunToolStripMenuItem_Click);
            // 
            // ghostModeToolStripMenuItem
            // 
            this.ghostModeToolStripMenuItem.ForeColor = System.Drawing.Color.Yellow;
            this.ghostModeToolStripMenuItem.Name = "ghostModeToolStripMenuItem";
            this.ghostModeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.ghostModeToolStripMenuItem.ShowShortcutKeys = false;
            this.ghostModeToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.ghostModeToolStripMenuItem.Text = "Ghost mode On";
            this.ghostModeToolStripMenuItem.Click += new System.EventHandler(this.ghostModeToolStripMenuItem_Click);
            // 
            // rapidFireToolStripMenuItem
            // 
            this.rapidFireToolStripMenuItem.ForeColor = System.Drawing.Color.Yellow;
            this.rapidFireToolStripMenuItem.Name = "rapidFireToolStripMenuItem";
            this.rapidFireToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.rapidFireToolStripMenuItem.ShowShortcutKeys = false;
            this.rapidFireToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.rapidFireToolStripMenuItem.Text = "Rapid Fire On";
            this.rapidFireToolStripMenuItem.Click += new System.EventHandler(this.rapidGunToolStripMenuItem_Click);
            // 
            // speedToolStripMenuItem
            // 
            this.speedToolStripMenuItem.ForeColor = System.Drawing.Color.Yellow;
            this.speedToolStripMenuItem.Name = "speedToolStripMenuItem";
            this.speedToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.speedToolStripMenuItem.ShowShortcutKeys = false;
            this.speedToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.speedToolStripMenuItem.Text = "Speed On";
            this.speedToolStripMenuItem.Click += new System.EventHandler(this.speedToolStripMenuItem_Click);
            // 
            // title
            // 
            this.title.Image = ((System.Drawing.Image)(resources.GetObject("title.Image")));
            this.title.Location = new System.Drawing.Point(0, 58);
            this.title.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(594, 196);
            this.title.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.title.TabIndex = 1;
            this.title.TabStop = false;
            // 
            // playLabel
            // 
            this.playLabel.AutoSize = true;
            this.playLabel.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playLabel.ForeColor = System.Drawing.Color.Yellow;
            this.playLabel.Location = new System.Drawing.Point(262, 317);
            this.playLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.playLabel.Name = "playLabel";
            this.playLabel.Size = new System.Drawing.Size(58, 23);
            this.playLabel.TabIndex = 2;
            this.playLabel.Text = "play";
            this.playLabel.Click += new System.EventHandler(this.playLabel_Click);
            // 
            // exitLabel
            // 
            this.exitLabel.AutoSize = true;
            this.exitLabel.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitLabel.ForeColor = System.Drawing.Color.Yellow;
            this.exitLabel.Location = new System.Drawing.Point(262, 366);
            this.exitLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.exitLabel.Name = "exitLabel";
            this.exitLabel.Size = new System.Drawing.Size(55, 23);
            this.exitLabel.TabIndex = 3;
            this.exitLabel.Text = "exit";
            this.exitLabel.Click += new System.EventHandler(this.exitLabel_Click);
            // 
            // levelSelectBox
            // 
            this.levelSelectBox.BackColor = System.Drawing.Color.Black;
            this.levelSelectBox.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelSelectBox.ForeColor = System.Drawing.Color.Yellow;
            this.levelSelectBox.FormattingEnabled = true;
            this.levelSelectBox.Location = new System.Drawing.Point(188, 268);
            this.levelSelectBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.levelSelectBox.Name = "levelSelectBox";
            this.levelSelectBox.Size = new System.Drawing.Size(248, 31);
            this.levelSelectBox.TabIndex = 4;
            this.levelSelectBox.Text = "choose a level ...";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(586, 466);
            this.Controls.Add(this.levelSelectBox);
            this.Controls.Add(this.exitLabel);
            this.Controls.Add(this.playLabel);
            this.Controls.Add(this.title);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "SharpShooter";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.title)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devToolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem weponSelectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pistolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sniperToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ballLauncherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ghostModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rapidFireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem speedToolStripMenuItem;
        private System.Windows.Forms.PictureBox title;
        private System.Windows.Forms.Label playLabel;
        private System.Windows.Forms.Label exitLabel;
        private System.Windows.Forms.ToolStripMenuItem superRapidGunToolStripMenuItem;
        private System.Windows.Forms.ComboBox levelSelectBox;
    }
}


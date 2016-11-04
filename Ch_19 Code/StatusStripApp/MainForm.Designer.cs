namespace StatusStripApp
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelMenuState = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelClock = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripDropDownButtonDateTime = new System.Windows.Forms.ToolStripDropDownButton();
            this.dayoftheWeekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerDateTimeUpdate = new System.Windows.Forms.Timer(this.components);
            this.mainStatusStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainStatusStrip
            // 
            this.mainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelMenuState,
            this.toolStripStatusLabelClock,
            this.toolStripDropDownButtonDateTime});
            this.mainStatusStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.mainStatusStrip.Location = new System.Drawing.Point(0, 78);
            this.mainStatusStrip.Name = "mainStatusStrip";
            this.mainStatusStrip.Size = new System.Drawing.Size(361, 27);
            this.mainStatusStrip.TabIndex = 0;
            this.mainStatusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabelMenuState
            // 
            this.toolStripStatusLabelMenuState.Name = "toolStripStatusLabelMenuState";
            this.toolStripStatusLabelMenuState.Spring = true;
            this.toolStripStatusLabelMenuState.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // toolStripStatusLabelClock
            // 
            this.toolStripStatusLabelClock.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabelClock.Name = "toolStripStatusLabelClock";
            // 
            // toolStripDropDownButtonDateTime
            // 
            this.toolStripDropDownButtonDateTime.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButtonDateTime.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dayoftheWeekToolStripMenuItem,
            this.currentTimeToolStripMenuItem});
            this.toolStripDropDownButtonDateTime.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButtonDateTime.Image")));
            this.toolStripDropDownButtonDateTime.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonDateTime.Name = "toolStripDropDownButtonDateTime";
            this.toolStripDropDownButtonDateTime.Text = "toolStripDropDownButton1";
            // 
            // dayoftheWeekToolStripMenuItem
            // 
            this.dayoftheWeekToolStripMenuItem.Name = "dayoftheWeekToolStripMenuItem";
            this.dayoftheWeekToolStripMenuItem.Text = "Day of the Week";
            this.dayoftheWeekToolStripMenuItem.MouseLeave += new System.EventHandler(this.SetReadyPrompt);
            this.dayoftheWeekToolStripMenuItem.MouseHover += new System.EventHandler(this.dayoftheWeekToolStripMenuItem_MouseHover);
            this.dayoftheWeekToolStripMenuItem.Click += new System.EventHandler(this.dayoftheWeekToolStripMenuItem_Click);
            // 
            // currentTimeToolStripMenuItem
            // 
            this.currentTimeToolStripMenuItem.Name = "currentTimeToolStripMenuItem";
            this.currentTimeToolStripMenuItem.Text = "Current Time";
            this.currentTimeToolStripMenuItem.MouseLeave += new System.EventHandler(this.SetReadyPrompt);
            this.currentTimeToolStripMenuItem.MouseHover += new System.EventHandler(this.currentTimeToolStripMenuItem_MouseHover);
            this.currentTimeToolStripMenuItem.Click += new System.EventHandler(this.currentTimeToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(361, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.MouseLeave += new System.EventHandler(this.SetReadyPrompt);
            this.exitToolStripMenuItem.MouseHover += new System.EventHandler(this.exitToolStripMenuItem_MouseHover);
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.MouseLeave += new System.EventHandler(this.SetReadyPrompt);
            this.aboutToolStripMenuItem.MouseHover += new System.EventHandler(this.aboutToolStripMenuItem_MouseHover);
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // timerDateTimeUpdate
            // 
            this.timerDateTimeUpdate.Enabled = true;
            this.timerDateTimeUpdate.Interval = 1000;
            this.timerDateTimeUpdate.Tick += new System.EventHandler(this.timerDateTimeUpdate_Tick);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 105);
            this.Controls.Add(this.mainStatusStrip);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.mainStatusStrip.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip mainStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelMenuState;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelClock;        
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonDateTime;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dayoftheWeekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem currentTimeToolStripMenuItem;
        private System.Windows.Forms.Timer timerDateTimeUpdate;



    }
}


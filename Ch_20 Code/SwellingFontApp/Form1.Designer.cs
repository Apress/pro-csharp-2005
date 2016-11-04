namespace SwellingFontApp
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.configureToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.swellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontFaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wingDingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listInstalledFontsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configureToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(367, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // configureToolStripMenuItem1
            // 
            this.configureToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.swellToolStripMenuItem,
            this.fontFaceToolStripMenuItem,
            this.listInstalledFontsToolStripMenuItem});
            this.configureToolStripMenuItem1.Name = "configureToolStripMenuItem1";
            this.configureToolStripMenuItem1.Text = "&Configure";
            // 
            // swellToolStripMenuItem
            // 
            this.swellToolStripMenuItem.Name = "swellToolStripMenuItem";
            this.swellToolStripMenuItem.Text = "&Swell?";
            this.swellToolStripMenuItem.Click += new System.EventHandler(this.swellToolStripMenuItem_Click);
            // 
            // fontFaceToolStripMenuItem
            // 
            this.fontFaceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arialToolStripMenuItem,
            this.timesToolStripMenuItem,
            this.wingDingsToolStripMenuItem});
            this.fontFaceToolStripMenuItem.Name = "fontFaceToolStripMenuItem";
            this.fontFaceToolStripMenuItem.Text = "&Font Face";
            // 
            // arialToolStripMenuItem
            // 
            this.arialToolStripMenuItem.Name = "arialToolStripMenuItem";
            this.arialToolStripMenuItem.Text = "&Arial";
            this.arialToolStripMenuItem.Click += new System.EventHandler(this.arialToolStripMenuItem_Click);
            // 
            // timesToolStripMenuItem
            // 
            this.timesToolStripMenuItem.Name = "timesToolStripMenuItem";
            this.timesToolStripMenuItem.Text = "&Times New Roman";
            this.timesToolStripMenuItem.Click += new System.EventHandler(this.timesToolStripMenuItem_Click);
            // 
            // wingDingsToolStripMenuItem
            // 
            this.wingDingsToolStripMenuItem.Name = "wingDingsToolStripMenuItem";
            this.wingDingsToolStripMenuItem.Text = "&WingDings";
            this.wingDingsToolStripMenuItem.Click += new System.EventHandler(this.wingDingsToolStripMenuItem_Click);
            // 
            // listInstalledFontsToolStripMenuItem
            // 
            this.listInstalledFontsToolStripMenuItem.Name = "listInstalledFontsToolStripMenuItem";
            this.listInstalledFontsToolStripMenuItem.Text = "&List Installed Fonts";
            this.listInstalledFontsToolStripMenuItem.Click += new System.EventHandler(this.listInstalledFontsToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 167);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Swelling Font App";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem configureToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem swellToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontFaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wingDingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listInstalledFontsToolStripMenuItem;
    }
}


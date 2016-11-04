namespace MenuStripApp
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
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeBackgroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBoxColor = new System.Windows.Forms.ToolStripTextBox();
            this.fontSizeContextStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.hugeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tinyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuStrip.SuspendLayout();
            this.fontSizeContextStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.changeBackgroundColorToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(300, 24);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "menuStrip1";
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
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // changeBackgroundColorToolStripMenuItem
            // 
            this.changeBackgroundColorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBoxColor});
            this.changeBackgroundColorToolStripMenuItem.Name = "changeBackgroundColorToolStripMenuItem";
            this.changeBackgroundColorToolStripMenuItem.Text = "Change Background Color";
            // 
            // toolStripTextBoxColor
            // 
            this.toolStripTextBoxColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText;
            this.toolStripTextBoxColor.Name = "toolStripTextBoxColor";
            this.toolStripTextBoxColor.Size = new System.Drawing.Size(100, 21);
            // 
            // fontSizeContextStrip
            // 
            this.fontSizeContextStrip.Enabled = true;
            this.fontSizeContextStrip.GripMargin = new System.Windows.Forms.Padding(2);
            this.fontSizeContextStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hugeToolStripMenuItem,
            this.normalToolStripMenuItem,
            this.tinyToolStripMenuItem});
            this.fontSizeContextStrip.Location = new System.Drawing.Point(25, 90);
            this.fontSizeContextStrip.Name = "contextMenuStrip1";
            this.fontSizeContextStrip.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fontSizeContextStrip.Size = new System.Drawing.Size(97, 70);
            // 
            // hugeToolStripMenuItem
            // 
            this.hugeToolStripMenuItem.Name = "hugeToolStripMenuItem";
            this.hugeToolStripMenuItem.Text = "Huge";
            this.hugeToolStripMenuItem.Click += new System.EventHandler(this.ContextMenuItemSelection_Clicked);
            // 
            // normalToolStripMenuItem
            // 
            this.normalToolStripMenuItem.Name = "normalToolStripMenuItem";
            this.normalToolStripMenuItem.Text = "Normal";
            this.normalToolStripMenuItem.Click += new System.EventHandler(this.ContextMenuItemSelection_Clicked);
            // 
            // tinyToolStripMenuItem
            // 
            this.tinyToolStripMenuItem.Name = "tinyToolStripMenuItem";
            this.tinyToolStripMenuItem.Text = "Tiny";
            this.tinyToolStripMenuItem.Click += new System.EventHandler(this.ContextMenuItemSelection_Clicked);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 145);
            this.ContextMenuStrip = this.fontSizeContextStrip;
            this.Controls.Add(this.mainMenuStrip);
            this.Name = "MainWindow";
            this.Text = "Menu Strip Example";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainWindow_Paint);
            this.mainMenuStrip.ResumeLayout(false);
            this.fontSizeContextStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeBackgroundColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxColor;
        private System.Windows.Forms.ContextMenuStrip fontSizeContextStrip;
        private System.Windows.Forms.ToolStripMenuItem hugeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tinyToolStripMenuItem;
    }
}


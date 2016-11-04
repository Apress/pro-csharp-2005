namespace CoorSystem
{
    partial class Form1
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
            this.unitOfMeasurementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pixelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.milliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pointToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.originToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem0by0 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5by5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem100by100 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unitOfMeasurementToolStripMenuItem,
            this.originToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 169);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(390, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // unitOfMeasurementToolStripMenuItem
            // 
            this.unitOfMeasurementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pixelToolStripMenuItem,
            this.inchToolStripMenuItem,
            this.milliToolStripMenuItem,
            this.displayToolStripMenuItem,
            this.documentToolStripMenuItem,
            this.pointToolStripMenuItem});
            this.unitOfMeasurementToolStripMenuItem.Name = "unitOfMeasurementToolStripMenuItem";
            this.unitOfMeasurementToolStripMenuItem.Text = "Unit Of Measurement";
            // 
            // pixelToolStripMenuItem
            // 
            this.pixelToolStripMenuItem.Name = "pixelToolStripMenuItem";
            this.pixelToolStripMenuItem.Text = "Pixel";
            this.pixelToolStripMenuItem.Click += new System.EventHandler(this.pixelToolStripMenuItem_Click);
            // 
            // inchToolStripMenuItem
            // 
            this.inchToolStripMenuItem.Name = "inchToolStripMenuItem";
            this.inchToolStripMenuItem.Text = "Inch";
            this.inchToolStripMenuItem.Click += new System.EventHandler(this.inchToolStripMenuItem_Click);
            // 
            // milliToolStripMenuItem
            // 
            this.milliToolStripMenuItem.Name = "milliToolStripMenuItem";
            this.milliToolStripMenuItem.Text = "Millimeter";
            this.milliToolStripMenuItem.Click += new System.EventHandler(this.milliToolStripMenuItem_Click);
            // 
            // displayToolStripMenuItem
            // 
            this.displayToolStripMenuItem.Name = "displayToolStripMenuItem";
            this.displayToolStripMenuItem.Text = "Display";
            this.displayToolStripMenuItem.Click += new System.EventHandler(this.displayToolStripMenuItem_Click);
            // 
            // documentToolStripMenuItem
            // 
            this.documentToolStripMenuItem.Name = "documentToolStripMenuItem";
            this.documentToolStripMenuItem.Text = "Document";
            this.documentToolStripMenuItem.Click += new System.EventHandler(this.documentToolStripMenuItem_Click);
            // 
            // pointToolStripMenuItem
            // 
            this.pointToolStripMenuItem.Name = "pointToolStripMenuItem";
            this.pointToolStripMenuItem.Text = "Point";
            this.pointToolStripMenuItem.Click += new System.EventHandler(this.pointToolStripMenuItem_Click);
            // 
            // originToolStripMenuItem
            // 
            this.originToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem0by0,
            this.toolStripMenuItem5by5,
            this.toolStripMenuItem100by100});
            this.originToolStripMenuItem.Name = "originToolStripMenuItem";
            this.originToolStripMenuItem.Text = "Origin";
            // 
            // toolStripMenuItem0by0
            // 
            this.toolStripMenuItem0by0.Name = "toolStripMenuItem0by0";
            this.toolStripMenuItem0by0.Text = "(0, 0)";
            this.toolStripMenuItem0by0.Click += new System.EventHandler(this.toolStripMenuItem0by0_Click);
            // 
            // toolStripMenuItem5by5
            // 
            this.toolStripMenuItem5by5.Name = "toolStripMenuItem5by5";
            this.toolStripMenuItem5by5.Text = "(5, 5)";
            this.toolStripMenuItem5by5.Click += new System.EventHandler(this.toolStripMenuItem5by5_Click);
            // 
            // toolStripMenuItem100by100
            // 
            this.toolStripMenuItem100by100.Name = "toolStripMenuItem100by100";
            this.toolStripMenuItem100by100.Text = "(100, 100)";
            this.toolStripMenuItem100by100.Click += new System.EventHandler(this.toolStripMenuItem100by100_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 193);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "GDI+ Coordinates";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.menuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem unitOfMeasurementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pixelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem milliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pointToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem originToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem0by0;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5by5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem100by100;
    }
}


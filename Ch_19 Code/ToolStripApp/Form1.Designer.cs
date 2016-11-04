namespace ToolStripApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonGrowFont = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonShrinkFont = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBoxMessage = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.toolStrip1.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonGrowFont,
            this.toolStripButtonShrinkFont,
            this.toolStripSeparator1,
            this.toolStripTextBoxMessage});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(196, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonGrowFont
            // 
            this.toolStripButtonGrowFont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonGrowFont.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonGrowFont.Image")));
            this.toolStripButtonGrowFont.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonGrowFont.Name = "toolStripButtonGrowFont";
            this.toolStripButtonGrowFont.Text = "toolStripButton2";
            this.toolStripButtonGrowFont.ToolTipText = "Grow Font";
            this.toolStripButtonGrowFont.Click += new System.EventHandler(this.toolStripButtonGrowFont_Click);
            // 
            // toolStripButtonShrinkFont
            // 
            this.toolStripButtonShrinkFont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonShrinkFont.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonShrinkFont.Image")));
            this.toolStripButtonShrinkFont.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonShrinkFont.Name = "toolStripButtonShrinkFont";
            this.toolStripButtonShrinkFont.Text = "toolStripButton1";
            this.toolStripButtonShrinkFont.ToolTipText = "Shrink Font";
            this.toolStripButtonShrinkFont.Click += new System.EventHandler(this.toolStripButtonShrinkFont_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            // 
            // toolStripTextBoxMessage
            // 
            this.toolStripTextBoxMessage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText;
            this.toolStripTextBoxMessage.Name = "toolStripTextBoxMessage";
            this.toolStripTextBoxMessage.Size = new System.Drawing.Size(100, 25);
            this.toolStripTextBoxMessage.Text = "Enter Message";
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ContentPanel_Paint);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(541, 222);
            this.toolStripContainer1.TabIndex = 1;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 222);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "MainWindow";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonShrinkFont;
        private System.Windows.Forms.ToolStripButton toolStripButtonGrowFont;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxMessage;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;



    }
}


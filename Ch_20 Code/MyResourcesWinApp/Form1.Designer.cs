namespace MyResourcesWinApp
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
            this.btnGetStringData = new System.Windows.Forms.Button();
            this.myPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.myPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGetStringData
            // 
            this.btnGetStringData.Location = new System.Drawing.Point(12, 12);
            this.btnGetStringData.Name = "btnGetStringData";
            this.btnGetStringData.Size = new System.Drawing.Size(188, 23);
            this.btnGetStringData.TabIndex = 0;
            this.btnGetStringData.Text = "Read embedded String data";
            this.btnGetStringData.Click += new System.EventHandler(this.btnGetStringData_Click);
            // 
            // myPictureBox
            // 
            this.myPictureBox.Location = new System.Drawing.Point(12, 52);
            this.myPictureBox.Name = "myPictureBox";
            this.myPictureBox.Size = new System.Drawing.Size(95, 77);
            this.myPictureBox.TabIndex = 1;
            this.myPictureBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 170);
            this.Controls.Add(this.myPictureBox);
            this.Controls.Add(this.btnGetStringData);
            this.Name = "MainForm";
            this.Text = "Resource Reader";
            ((System.ComponentModel.ISupportInitialize)(this.myPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetStringData;
        private System.Windows.Forms.PictureBox myPictureBox;
    }
}


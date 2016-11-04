namespace ResXWriter
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
            this.btnGenResX = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGenResX
            // 
            this.btnGenResX.Location = new System.Drawing.Point(13, 13);
            this.btnGenResX.Name = "btnGenResX";
            this.btnGenResX.Size = new System.Drawing.Size(267, 23);
            this.btnGenResX.TabIndex = 0;
            this.btnGenResX.Text = "Generate a *.resx file";
            this.btnGenResX.Click += new System.EventHandler(this.btnGenResX_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 62);
            this.Controls.Add(this.btnGenResX);
            this.Name = "Form1";
            this.Text = "ResX Writer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenResX;
    }
}


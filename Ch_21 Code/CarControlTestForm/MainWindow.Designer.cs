namespace CarControlTestForm
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
            this.myCarControl = new CarControlLibrary.CarControl();
            this.lblCurrentSpeed = new System.Windows.Forms.Label();
            this.lblEventData = new System.Windows.Forms.Label();
            this.numericUpDownCarSpeed = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCarSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // myCarControl
            // 
            this.myCarControl.Animate = false;
            this.myCarControl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.myCarControl.Location = new System.Drawing.Point(13, 13);
            this.myCarControl.Name = "myCarControl";
            this.myCarControl.Size = new System.Drawing.Size(150, 150);
            this.myCarControl.Speed = 50;
            this.myCarControl.TabIndex = 0;
            this.myCarControl.BlewUp += new CarControlLibrary.CarControl.CarEventHandler(this.myCarControl_BlewUp);
            this.myCarControl.AboutToBlow += new CarControlLibrary.CarControl.CarEventHandler(this.myCarControl_AboutToBlow);
            // 
            // lblCurrentSpeed
            // 
            this.lblCurrentSpeed.AutoSize = true;
            this.lblCurrentSpeed.Location = new System.Drawing.Point(169, 13);
            this.lblCurrentSpeed.Name = "lblCurrentSpeed";
            this.lblCurrentSpeed.Size = new System.Drawing.Size(74, 13);
            this.lblCurrentSpeed.TabIndex = 1;
            this.lblCurrentSpeed.Text = "Current Speed:";
            // 
            // lblEventData
            // 
            this.lblEventData.AutoSize = true;
            this.lblEventData.Location = new System.Drawing.Point(169, 41);
            this.lblEventData.Name = "lblEventData";
            this.lblEventData.Size = new System.Drawing.Size(60, 13);
            this.lblEventData.TabIndex = 2;
            this.lblEventData.Text = "Event Data:";
            // 
            // numericUpDownCarSpeed
            // 
            this.numericUpDownCarSpeed.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownCarSpeed.Location = new System.Drawing.Point(170, 104);
            this.numericUpDownCarSpeed.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDownCarSpeed.Name = "numericUpDownCarSpeed";
            this.numericUpDownCarSpeed.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownCarSpeed.TabIndex = 3;
            this.numericUpDownCarSpeed.ValueChanged += new System.EventHandler(this.numericUpDownCarSpeed_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Speed +/- 10 ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 186);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownCarSpeed);
            this.Controls.Add(this.lblEventData);
            this.Controls.Add(this.lblCurrentSpeed);
            this.Controls.Add(this.myCarControl);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CarControl Test Form";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCarSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CarControlLibrary.CarControl myCarControl;
        private System.Windows.Forms.Label lblCurrentSpeed;
        private System.Windows.Forms.Label lblEventData;
        private System.Windows.Forms.NumericUpDown numericUpDownCarSpeed;
        private System.Windows.Forms.Label label1;
    }
}


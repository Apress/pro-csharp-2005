using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Buttons
{
    partial class MainForm : Form
    {
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnStandard = new System.Windows.Forms.Button();
            this.btnFlat = new System.Windows.Forms.Button();
            this.btnImage = new System.Windows.Forms.Button();
            this.btnPopup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStandard
            // 
            this.btnStandard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnStandard.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStandard.Location = new System.Drawing.Point(16, 80);
            this.btnStandard.Name = "btnStandard";
            this.btnStandard.Size = new System.Drawing.Size(312, 88);
            this.btnStandard.TabIndex = 2;
            this.btnStandard.Text = "I am a standard button";
            this.btnStandard.Click += new System.EventHandler(this.btnStandard_Click);
            // 
            // btnFlat
            // 
            this.btnFlat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFlat.ForeColor = System.Drawing.Color.Blue;
            this.btnFlat.Location = new System.Drawing.Point(16, 24);
            this.btnFlat.Name = "btnFlat";
            this.btnFlat.Size = new System.Drawing.Size(152, 32);
            this.btnFlat.TabIndex = 0;
            this.btnFlat.Text = "I am flat...";
            // 
            // btnImage
            // 
            this.btnImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnImage.BackgroundImage")));
            this.btnImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.btnImage.ForeColor = System.Drawing.Color.Black;
            this.btnImage.Image = ((System.Drawing.Image)(resources.GetObject("btnImage.Image")));
            this.btnImage.Location = new System.Drawing.Point(16, 192);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(312, 72);
            this.btnImage.TabIndex = 3;
            this.btnImage.Text = "Image Button";
            this.btnImage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnPopup
            // 
            this.btnPopup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPopup.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPopup.Location = new System.Drawing.Point(176, 24);
            this.btnPopup.Name = "btnPopup";
            this.btnPopup.Size = new System.Drawing.Size(152, 32);
            this.btnPopup.TabIndex = 1;
            this.btnPopup.Text = "I am a Popup!";
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(340, 269);
            this.Controls.Add(this.btnImage);
            this.Controls.Add(this.btnStandard);
            this.Controls.Add(this.btnPopup);
            this.Controls.Add(this.btnFlat);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainForm";
            this.Text = "Buttons";
            this.ResumeLayout(false);

        }
        #endregion

        private System.ComponentModel.Container components = null;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.Button btnStandard;
        private System.Windows.Forms.Button btnPopup;
        private System.Windows.Forms.Button btnFlat;
    }
}

namespace LabelsAndTextBoxes
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
        this.lblPassword = new System.Windows.Forms.Label();
        this.txtPassword = new System.Windows.Forms.TextBox();
        this.lblMultiline = new System.Windows.Forms.Label();
        this.txtMultiline = new System.Windows.Forms.TextBox();
        this.lblUpperCaseOnly = new System.Windows.Forms.Label();
        this.txtUpperCase = new System.Windows.Forms.TextBox();
        this.lblMaskedTextBox = new System.Windows.Forms.Label();
        this.txtMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
        this.btnDisplayData = new System.Windows.Forms.Button();
        this.SuspendLayout();
        // 
        // lblPassword
        // 
        this.lblPassword.AutoSize = true;
        this.lblPassword.Location = new System.Drawing.Point(13, 43);
        this.lblPassword.Name = "lblPassword";
        this.lblPassword.Size = new System.Drawing.Size(94, 13);
        this.lblPassword.TabIndex = 0;
        this.lblPassword.Text = "&Password TextBox:";
        // 
        // txtPassword
        // 
        this.txtPassword.Location = new System.Drawing.Point(125, 43);
        this.txtPassword.Name = "txtPassword";
        this.txtPassword.PasswordChar = '*';
        this.txtPassword.Size = new System.Drawing.Size(220, 20);
        this.txtPassword.TabIndex = 1;
        // 
        // lblMultiline
        // 
        this.lblMultiline.AutoSize = true;
        this.lblMultiline.Location = new System.Drawing.Point(14, 80);
        this.lblMultiline.Name = "lblMultiline";
        this.lblMultiline.Size = new System.Drawing.Size(86, 13);
        this.lblMultiline.TabIndex = 2;
        this.lblMultiline.Text = "&Multiline TextBox:";
        // 
        // txtMultiline
        // 
        this.txtMultiline.Location = new System.Drawing.Point(125, 80);
        this.txtMultiline.Multiline = true;
        this.txtMultiline.Name = "txtMultiline";
        this.txtMultiline.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        this.txtMultiline.Size = new System.Drawing.Size(220, 52);
        this.txtMultiline.TabIndex = 3;
        // 
        // lblUpperCaseOnly
        // 
        this.lblUpperCaseOnly.AutoSize = true;
        this.lblUpperCaseOnly.Location = new System.Drawing.Point(15, 157);
        this.lblUpperCaseOnly.Name = "lblUpperCaseOnly";
        this.lblUpperCaseOnly.Size = new System.Drawing.Size(82, 13);
        this.lblUpperCaseOnly.TabIndex = 4;
        this.lblUpperCaseOnly.Text = "&Uppercase Only:";
        // 
        // txtUpperCase
        // 
        this.txtUpperCase.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
        this.txtUpperCase.Location = new System.Drawing.Point(125, 157);
        this.txtUpperCase.Name = "txtUpperCase";
        this.txtUpperCase.Size = new System.Drawing.Size(220, 20);
        this.txtUpperCase.TabIndex = 5;
        // 
        // lblMaskedTextBox
        // 
        this.lblMaskedTextBox.AutoSize = true;
        this.lblMaskedTextBox.Location = new System.Drawing.Point(15, 199);
        this.lblMaskedTextBox.Name = "lblMaskedTextBox";
        this.lblMaskedTextBox.Size = new System.Drawing.Size(83, 13);
        this.lblMaskedTextBox.TabIndex = 7;
        this.lblMaskedTextBox.Text = "Mas&ked TextBox";
        // 
        // txtMaskedTextBox
        // 
        this.txtMaskedTextBox.BeepOnError = true;
        this.txtMaskedTextBox.CausesValidation = false;
        this.txtMaskedTextBox.Location = new System.Drawing.Point(125, 199);
        this.txtMaskedTextBox.Mask = "(999) 000-0000";
        this.txtMaskedTextBox.Name = "txtMaskedTextBox";
        this.txtMaskedTextBox.Size = new System.Drawing.Size(220, 20);
        this.txtMaskedTextBox.TabIndex = 8;
        this.txtMaskedTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMaskedTextBox_KeyDown);
        this.txtMaskedTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtMaskedTextBox_MaskInputRejected);
        // 
        // btnDisplayData
        // 
        this.btnDisplayData.Location = new System.Drawing.Point(257, 236);
        this.btnDisplayData.Name = "btnDisplayData";
        this.btnDisplayData.Size = new System.Drawing.Size(88, 23);
        this.btnDisplayData.TabIndex = 6;
        this.btnDisplayData.Text = "Display Data";
        this.btnDisplayData.Click += new System.EventHandler(this.btnDisplayData_Click);
        // 
        // MainWindow
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(357, 276);
        this.Controls.Add(this.txtMaskedTextBox);
        this.Controls.Add(this.lblMaskedTextBox);
        this.Controls.Add(this.btnDisplayData);
        this.Controls.Add(this.txtUpperCase);
        this.Controls.Add(this.lblUpperCaseOnly);
        this.Controls.Add(this.txtMultiline);
        this.Controls.Add(this.lblMultiline);
        this.Controls.Add(this.txtPassword);
        this.Controls.Add(this.lblPassword);
        this.Name = "MainWindow";
        this.Text = "Fun with Labels and TextBoxes";
        this.ResumeLayout(false);
        this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblMultiline;
        private System.Windows.Forms.TextBox txtMultiline;
        private System.Windows.Forms.Label lblUpperCaseOnly;
        private System.Windows.Forms.TextBox txtUpperCase;
        private System.Windows.Forms.Label lblMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox txtMaskedTextBox;
        private System.Windows.Forms.Button btnDisplayData;
    }
}


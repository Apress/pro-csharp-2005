using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LabelsAndTextBoxes
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            CreateLabelControl();
            CenterToScreen();
        }

        private void btnDisplayData_Click(object sender, EventArgs e)
        {
            // Get data from all the text boxes.
            string textBoxData = "";
            textBoxData += string.Format("MultiLine:  {0}\n", txtMultiline.Text);
            textBoxData += string.Format("\nPassword:  {0}\n", txtPassword.Text);
            textBoxData += string.Format("\nUppercase:  {0}\n", txtUpperCase.Text);
            textBoxData += string.Format("\nMasked:  {0}\n", txtMaskedTextBox.Text);

            // Display all the data. 
            MessageBox.Show(textBoxData, "Here is the data in your TextBoxes");
        }

        private void CreateLabelControl()
        {
            // Create and configure a Label.
            Label lblInstructions = new Label();
            lblInstructions.Name = "lblInstructions";
            lblInstructions.Text = "Please enter values in all the text boxes";
            lblInstructions.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            lblInstructions.AutoSize = true;

            lblInstructions.Location = new System.Drawing.Point(16, 13);
            lblInstructions.Size = new System.Drawing.Size(240, 16);

            // Add to Form's controls collection.
            this.Controls.Add(lblInstructions);
        }

        private void txtMaskedTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            this.Text = string.Format("Error: {0}", e.RejectionHint);
        }

        private void txtMaskedTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            this.Text = "Fun with Labels and TextBoxes";
        }
    }
}
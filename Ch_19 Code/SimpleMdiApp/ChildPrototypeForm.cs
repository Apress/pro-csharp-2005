using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SimpleMdiApp
{
    public partial class ChildPrototypeForm : Form
    {
        public ChildPrototypeForm()
        {
            InitializeComponent();
        }

        private void ChildPrototypeForm_Click(object sender, EventArgs e)
        {
            // Get three random numbers
            int r, g, b;
            Random ran = new Random();
            r = ran.Next(0, 255);
            g = ran.Next(0, 255);
            b = ran.Next(0, 255);

            // Now create a color for the background.
            Color currColor = Color.FromArgb(r, g, b);
            this.BackColor = currColor;
            this.Text = currColor.ToString();
        }
    }
}
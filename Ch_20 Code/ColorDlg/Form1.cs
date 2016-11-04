using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ColorDlg
{
    public partial class MainForm : Form
    {
        private ColorDialog colorDlg;
        private Color currColor = Color.DimGray;

        public MainForm()
        {
            InitializeComponent();
            CenterToScreen();
            colorDlg = new ColorDialog();
            Text = "Click on me to change the color";
            this.MouseDown += new MouseEventHandler(MainForm_MouseDown);
        }

        void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (colorDlg.ShowDialog() != DialogResult.Cancel)
            {
                currColor = colorDlg.Color;
                this.BackColor = currColor;
                // Show current color.
                string strARGB = colorDlg.Color.ToString();
                MessageBox.Show(strARGB, "Color is:");
            }
        }
    }
}
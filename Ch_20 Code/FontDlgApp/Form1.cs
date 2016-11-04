using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FontDlgApp
{
    public partial class MainForm : Form
    {
        private FontDialog fontDlg = new FontDialog();
        private Font currFont = new Font("Times New Roman", 12);

        public MainForm()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (fontDlg.ShowDialog() != DialogResult.Cancel)
            {
                currFont = fontDlg.Font;
                this.Text = string.Format("Selected Font: {0}", currFont);
                Invalidate();
            } 
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawString("Testing...", currFont, Brushes.Black, 0, 0);
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FontFamilyApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            FontFamily myFamily = new FontFamily("Verdana");
            Font myFont = new Font(myFamily, 12);
            int y = 0;
            int fontHeight = myFont.Height;     // Get pixel height of font.
            // Show units of measurement for FontFamily members.
            this.Text = "Measurements are in GraphicsUnit." + myFont.Unit;
            g.DrawString("The Verdana family.", myFont, Brushes.Blue, 10, y);
            y += 20;
            // Print our family ties...
            g.DrawString("Ascent for bold Verdana: " +
                         myFamily.GetCellAscent(FontStyle.Bold),
                         myFont, Brushes.Black, 10, y + fontHeight);
            y += 20;
            g.DrawString("Descent for bold Verdana: " +
                         myFamily.GetCellDescent(FontStyle.Bold),
                         myFont, Brushes.Black, 10, y + fontHeight);
            y += 20;
            g.DrawString("Line spacing for bold Verdana: " +
                         myFamily.GetLineSpacing(FontStyle.Bold),
                         myFont, Brushes.Black, 10, y + fontHeight);
            y += 20;
            g.DrawString("Height for bold Verdana: " +
                         myFamily.GetEmHeight(FontStyle.Bold),
                         myFont, Brushes.Black, 10, y + fontHeight);
            y += 20;

        }
    }
}
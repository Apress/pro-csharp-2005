using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Text;

namespace SwellingFontApp
{
    public partial class MainForm : Form
    {
        private Timer swellTimer = new Timer();
        private int swellValue;
        private string strFontFace = "WingDings";
        private string installedFonts;

        public MainForm()
        {
            InitializeComponent();
            BackColor = Color.Honeydew;
            CenterToScreen();

            // Configure the Timer.
            swellTimer.Enabled = true;
            swellTimer.Interval = 100;
            swellTimer.Tick += new EventHandler(swellTimer_Tick);

        }

        void swellTimer_Tick(object sender, EventArgs e)
        {
            // Increase current swellValue by 5.
            swellValue += 5;
            // If this value is greater than or equal to 50, reset to zero.
            if (swellValue >= 50)
                swellValue = 0;
            // Just invalidate the 'minimal dirty rectangle to help reduce flicker.
            Invalidate(new Rectangle(0, 0, ClientRectangle.Width, 100));
        }

        private void swellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            swellTimer.Enabled = !swellTimer.Enabled;
        }

        private void arialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            strFontFace = "Arial";
            Invalidate();
        }

        private void timesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            strFontFace = "Times New Roman";
            Invalidate();
        }

        private void wingDingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            strFontFace = "WingDings";
            Invalidate();
        }

        private void listInstalledFontsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InstalledFontCollection fonts = new InstalledFontCollection();
            for (int i = 0; i < fonts.Families.Length; i++)
                installedFonts += fonts.Families[i].Name + "  ";
            // This time, we need to invalidate the entire client area,
            // as we will paint the installedFonts string on the lower half
            // of the client rectangle.
            Invalidate();
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Font theFont = new Font(strFontFace, 12 + swellValue);
            string message = "Hello GDI+";

            // Display message in the center of the window!
            float windowCenter = this.DisplayRectangle.Width / 2;
            SizeF stringSize = e.Graphics.MeasureString(message, theFont);
            float startPos = windowCenter - (stringSize.Width / 2);
            g.DrawString(message, theFont, Brushes.Blue, startPos, 10);

            // Show installed fonts in the rectangle below the swell area.
            Rectangle myRect = new Rectangle(0, 100,
                 ClientRectangle.Width, ClientRectangle.Height);

            // Paint this area of the Form black.
            g.FillRectangle(new SolidBrush(Color.Black), myRect);
            g.DrawString(installedFonts, new Font("Arial", 12),
                 Brushes.White, myRect);
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            Rectangle myRect = new Rectangle(0, 100,
                ClientRectangle.Width, ClientRectangle.Height);
            Invalidate(myRect);
        }
    }
}
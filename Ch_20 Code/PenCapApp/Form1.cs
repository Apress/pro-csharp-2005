using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace PenCapApp
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
            Pen thePen = new Pen(Color.Black, 10);
            int yOffSet = 10;
            // Get all members of the LineCap enum.
            Array obj = Enum.GetValues(typeof(LineCap));
            // Draw a line with a LineCap member.
            for (int x = 0; x < obj.Length; x++)
            {
                // Get next cap and configure pen.
                LineCap temp = (LineCap)obj.GetValue(x);
                thePen.StartCap = temp;
                thePen.EndCap = temp;
                // Print name of LineCap enum.
                g.DrawString(temp.ToString(), new Font("Times New Roman", 10),
                             new SolidBrush(Color.Black), 0, yOffSet);
                // Draw a line with the correct cap.
                g.DrawLine(thePen, 100, yOffSet, Width - 50, yOffSet);
                yOffSet += 40;
            }
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}
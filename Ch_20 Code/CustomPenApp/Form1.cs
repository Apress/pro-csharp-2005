using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace CustomPenApp
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

            // Make a big blue pen.
            Pen bluePen = new Pen(Color.Blue, 20);

            // Get a stock pen from the Pens type.
            Pen pen2 = Pens.Firebrick;

            // Render some shapes with the pens.
            g.DrawEllipse(bluePen, 10, 10, 100, 100);
            g.DrawLine(pen2, 10, 130, 110, 130);
            g.DrawPie(Pens.Black, 150, 10, 120, 150, 90, 80);

            // Draw a purple dashed polygon as well...
            Pen pen3 = new Pen(Color.Purple, 5);
            pen3.DashStyle = DashStyle.DashDotDot;
            g.DrawPolygon(pen3, new Point[]{     new Point(30, 140),
          new Point(265, 200), new Point(100, 225),
          new Point(190, 190), new Point(50, 330),
          new Point(20, 180)});

            // And a rectangle containing some text...
            Rectangle r = new Rectangle(150, 10, 130, 60);
            g.DrawRectangle(Pens.Blue, r);
            g.DrawString("Hello out there...How are ya?",
                         new Font("Arial", 12), Brushes.Black, r);

            // Draw custom dash pattern all around the boarder of the form.
            Pen customDashPen = new Pen(Color.BlueViolet, 10);
            float[] myDashes = { 5.0f, 2.0f, 1.0f, 3.0f };
            customDashPen.DashPattern = myDashes;
            g.DrawRectangle(customDashPen, ClientRectangle);
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}
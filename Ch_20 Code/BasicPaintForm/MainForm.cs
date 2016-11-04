using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BasicPaintForm
{
    public partial class MainForm : Form
    {
        // Used to hold all the points.
        private List<Point> myPts = new List<Point>();

        public MainForm()
        {
            InitializeComponent();
            CenterToScreen();
            this.Text = "Basic Paint Form";
            this.Paint += new PaintEventHandler(MainForm_Paint);
            this.MouseDown += new MouseEventHandler(MainForm_MouseDown);
        }

        void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            // Add to points collection.
            myPts.Add(new Point(e.X, e.Y));
            Invalidate();
        }

        public void MainForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawString("Hello GDI+", new Font("Times New Roman", 20),
                         Brushes.Green, 0, 0);

            foreach (Point p in myPts)
                g.FillEllipse(Brushes.Firebrick, p.X, p.Y, 10, 10);
        } 
    }
}
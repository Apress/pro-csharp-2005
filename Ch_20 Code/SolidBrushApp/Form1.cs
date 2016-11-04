using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SolidBrushApp
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
            // Make a blue SolidBrush.
            SolidBrush blueBrush = new SolidBrush(Color.Blue);
            // Get a stock brush from the Brushes type.
            SolidBrush pen2 = (SolidBrush)Brushes.Firebrick;
            // Render some shapes with the brushes.
            g.FillEllipse(blueBrush, 10, 10, 100, 100);
            g.FillPie(Brushes.Black, 150, 10, 120, 150, 90, 80);
            // Draw a purple polygon as well...
            SolidBrush brush3 = new SolidBrush(Color.Purple);
            g.FillPolygon(brush3, 
                new Point[]{ new Point(30, 140),
                new Point(265, 200), new Point(100, 225),
                new Point(190, 190), new Point(50, 330),
                new Point(20, 180)});
            // And a rectangle with some text...
            Rectangle r = new Rectangle(150, 10, 130, 60);
            g.FillRectangle(Brushes.Blue, r);
            g.DrawString("Hello out there...How are ya?",
                         new Font("Arial", 12), Brushes.White, r);
        }
    }
}
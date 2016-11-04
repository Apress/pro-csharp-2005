using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CoorSystem
{
    public partial class Form1 : Form
    {
        // The unit of measurement.
        GraphicsUnit gUnit = GraphicsUnit.Pixel;

        // Point of origin.
        Point renderingOrgPt = new Point(0, 0);

        public Form1()
        {
            InitializeComponent();
            CenterToScreen();
        }

        #region Menu Click Event Handlers

        private void pixelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gUnit = GraphicsUnit.Pixel;
            Invalidate();
        }

        private void inchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gUnit = GraphicsUnit.Inch;
            Invalidate();
        }

        private void milliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gUnit = GraphicsUnit.Millimeter;
            Invalidate();
        }

        private void displayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gUnit = GraphicsUnit.Display;
            Invalidate();
        }

        private void documentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gUnit = GraphicsUnit.Document;
            Invalidate();
        }

        private void pointToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gUnit = GraphicsUnit.Point;
            Invalidate();
        }

        private void toolStripMenuItem0by0_Click(object sender, EventArgs e)
        {
            renderingOrgPt.X = 0;
            renderingOrgPt.Y = 0;
            Invalidate();
        }

        private void toolStripMenuItem5by5_Click(object sender, EventArgs e)
        {
            renderingOrgPt.X = 5;
            renderingOrgPt.Y = 5;
            Invalidate();
        }

        private void toolStripMenuItem100by100_Click(object sender, EventArgs e)
        {
            renderingOrgPt.X = 100;
            renderingOrgPt.Y = 100;
            Invalidate();
        } 
        #endregion

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Configure graphics unit.
            g.PageUnit = gUnit;

            // Configure origin.
            g.TranslateTransform(renderingOrgPt.X,
                renderingOrgPt.Y);
            g.DrawRectangle(new Pen(Color.Red, 1), 0, 0, 100, 100);

            this.Text = string.Format("PageUnit: {0}, Origin: {1}",
                gUnit, renderingOrgPt.ToString());
            }
    }
}
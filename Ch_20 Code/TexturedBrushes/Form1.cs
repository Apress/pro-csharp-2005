using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TexturedBrushes
{
    public partial class MainForm : Form
    {

        private Brush texturedTextBrush;
        private Brush texturedBGroundBrush;

        public MainForm()
        {
            InitializeComponent();
            CenterToScreen();

            // Load image for background brush.
            Image bGroundBrushImage = new Bitmap("Clouds.bmp");
            texturedBGroundBrush = new TextureBrush(bGroundBrushImage);
            // Now load image for text brush.
            Image textBrushImage = new Bitmap("Soap Bubbles.bmp");
            texturedTextBrush = new TextureBrush(textBrushImage);
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle r = ClientRectangle;
            // Paint the clouds on the client area.
            g.FillRectangle(texturedBGroundBrush, r);
            // Some big bold text with a textured brush.
            g.DrawString("Bitmaps as brushes!  Way cool...",
                         new Font("Arial", 30,
                         FontStyle.Bold | FontStyle.Italic),
                         texturedTextBrush,
                         r);

        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BasicImages
{
    public partial class MainForm : Form
    {
        private Bitmap[] myImages = new Bitmap[3];

        public MainForm()
        {
            // Load some local images.
            myImages[0] = new Bitmap("imageA.bmp");
            myImages[1] = new Bitmap("imageB.bmp");
            myImages[2] = new Bitmap("imageC.bmp");

            CenterToScreen();
            InitializeComponent();
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            
            // Render all three images.
            int yOffset = 10;
            foreach (Bitmap b in myImages)
            {
                g.DrawImage(b, 10, yOffset, 90, 90);
                yOffset += 100;
            }
        }
    }
}
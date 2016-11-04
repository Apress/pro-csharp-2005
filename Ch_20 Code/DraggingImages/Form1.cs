using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DraggingImages
{
    public partial class MainForm : Form
    {
        private PictureBox happyBox = new PictureBox();
        private int oldX, oldY;
        private bool isDragging;
        private Rectangle dropRect = new Rectangle(100, 100, 140, 170);

        public MainForm()
        {
            // Configure the PictureBox and add to 
            // the Form's Controls collection.
            happyBox.SizeMode = PictureBoxSizeMode.StretchImage;
            happyBox.Location = new System.Drawing.Point(64, 32);
            happyBox.Size = new System.Drawing.Size(50, 50);
            happyBox.Cursor = Cursors.Hand;
            happyBox.Image = new Bitmap("happyDude.bmp");

            // Add handlers for the following events.
            happyBox.MouseDown += new MouseEventHandler(happyBox_MouseDown);
            happyBox.MouseUp += new MouseEventHandler(happyBox_MouseUp);
            happyBox.MouseMove += new MouseEventHandler(happyBox_MouseMove); 
            Controls.Add(happyBox);
            InitializeComponent();
        }

        void happyBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                // Need to figure new Y value based on where the mouse
                // down click happened.
                happyBox.Top = happyBox.Top + (e.Y - oldY);
                // Same deal for X (use oldX as a base line).
                happyBox.Left = happyBox.Left + (e.X - oldX);
            } 
        }

        void happyBox_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
            // Is the mouse within the area of the drop rect?
            if (dropRect.Contains(happyBox.Bounds))
                MessageBox.Show("You win!", "What an amazing test of skill...");
        }

        void happyBox_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            // Save the (x, y) of the mouse down click, 
            // because we need it as an offset when dragging the image.
            oldX = e.X;
            oldY = e.Y;
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            // Draw the drop box.
            Graphics g = e.Graphics;
            g.FillRectangle(Brushes.BlueViolet, dropRect);
            // Display instructions.
            g.DrawString("Drag the happy guy in here...",
                 new Font("Times New Roman", 25), Brushes.WhiteSmoke, dropRect);
        }
    }
}
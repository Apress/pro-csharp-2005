using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

    namespace HitTestingImages
{
    enum ClickedImage
    {   
        ImageA, ImageB, 
        ImageC, StrangePath 
    }

    public partial class MainForm : Form
    {
        private Bitmap[] myImages = new Bitmap[3];
        private Rectangle[] imageRects = new Rectangle[3];
        private bool isImageClicked = false;
        ClickedImage imageClicked = ClickedImage.ImageA;
        GraphicsPath myPath = new GraphicsPath();

        // Specify ARGB manually.
        Color myColor;

        public MainForm()
        {
            // Load some local images.
            myImages[0] = new Bitmap("imageA.bmp");
            myImages[1] = new Bitmap("imageB.bmp");
            myImages[2] = new Bitmap("imageC.bmp");

            // Set up the rectangles.
            imageRects[0] = new Rectangle(10, 10, 90, 90);
            imageRects[1] = new Rectangle(10, 110, 90, 90);
            imageRects[2] = new Rectangle(10, 210, 90, 90);

            // Create an interesting path.
            myPath.StartFigure();
            myPath.AddLine(new Point(150, 10), new Point(120, 150));
            myPath.AddArc(200, 200, 100, 100, 0, 90);
            Point point1 = new Point(250, 250);
            Point point2 = new Point(350, 275);
            Point point3 = new Point(350, 325);
            Point point4 = new Point(250, 350);
            Point[] points = { point1, point2, point3, point4 };
            myPath.AddCurve(points);
            myPath.CloseFigure();

            CenterToScreen();
            InitializeComponent();
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            // Get (x, y) of mouse click.
            Point mousePt = new Point(e.X, e.Y);
            // See if the mouse is anywhere in the 3 Rectangles.
            if (imageRects[0].Contains(mousePt))
            {
                isImageClicked = true;
                imageClicked = ClickedImage.ImageA;
                this.Text = "You clicked image A";
            }
            else if (imageRects[1].Contains(mousePt))
            {
                isImageClicked = true;
                imageClicked = ClickedImage.ImageB;
                this.Text = "You clicked image B";
            }
            else if (imageRects[2].Contains(mousePt))
            {
                isImageClicked = true;
                imageClicked = ClickedImage.ImageC;
                this.Text = "You clicked image C";
            }
            else if (myPath.IsVisible(mousePt))
            {
                isImageClicked = true;
                imageClicked = ClickedImage.StrangePath;
                this.Text = "You clicked the strange shape...";
            } 
            else     // Not in any shape, set defaults.
            {
                isImageClicked = false;
                this.Text = "Hit Testing Images";
            }
            // Redraw the client area.
            Invalidate();
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Draw the graphics path.
            g.FillPath(Brushes.Sienna, myPath);

            // Render all three images.
            int yOffset = 10;
            foreach (Bitmap b in myImages)
            {
                g.DrawImage(b, 10, yOffset, 90, 90);
                yOffset += 100;
            }

            // Draw outline (if clicked)
            if (isImageClicked == true)
            {
                Pen outline = new Pen(Color.Tomato, 5);
                switch (imageClicked)
                {
                    case ClickedImage.ImageA:
                        g.DrawRectangle(outline, imageRects[0]);
                        break;
                    case ClickedImage.ImageB:
                        g.DrawRectangle(outline, imageRects[1]);
                        break;
                    case ClickedImage.ImageC:
                        g.DrawRectangle(outline, imageRects[2]);
                        break;
                    case ClickedImage.StrangePath:
                        g.DrawPath(outline, myPath);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
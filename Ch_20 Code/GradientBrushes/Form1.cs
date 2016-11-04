using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace GradientBrushes
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            CenterToScreen();
            InitializeComponent();
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle r = new Rectangle(10, 10, 100, 100);
            // A gradient brush.
            LinearGradientBrush theBrush = null;
            int yOffSet = 10;
            // Get all members of the LinearGradientMode enum.
            Array obj = Enum.GetValues(typeof(LinearGradientMode));
            // Draw an oval with a LinearGradientMode member.
            for (int x = 0; x < obj.Length; x++)
            {
                // Configure Brush.
                LinearGradientMode temp = (LinearGradientMode)obj.GetValue(x);
                theBrush = new LinearGradientBrush(r, Color.GreenYellow,
                                                   Color.Blue, temp);
                // Print name of LinearGradientMode enum.
                g.DrawString(temp.ToString(), new Font("Times New Roman", 10),
                             new SolidBrush(Color.Black), 0, yOffSet);
                // Fill a rectangle with the correct brush.
                g.FillRectangle(theBrush, 150, yOffSet, 200, 50);
                yOffSet += 80;
            } 
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace BrushStyles
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
            int yOffSet = 10;
            // Get all members of the HatchStyle enum.
            Array obj = Enum.GetValues(typeof(HatchStyle));
            // Draw an oval with first 5 HatchStyle values.
            for (int x = 0; x < 5; x++)
            {
                // Configure Brush.
                HatchStyle temp = (HatchStyle)obj.GetValue(x);
                HatchBrush theBrush = new HatchBrush(temp,
                     Color.White, Color.Black);
                // Print name of HatchStyle enum.
                g.DrawString(temp.ToString(), new Font("Times New Roman", 10),
                             Brushes.Black, 0, yOffSet);
                // Fill a rectangle with the correct brush.
                g.FillEllipse(theBrush, 150, yOffSet, 200, 25);
                yOffSet += 40;
            }
        }
    }
}
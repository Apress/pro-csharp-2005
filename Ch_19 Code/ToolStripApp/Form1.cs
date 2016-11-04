using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ToolStripApp
{
    public partial class MainWindow : Form
    {
        int currFontSize = 12;
        const int MinFontSize = 12;
        const int MaxFontSize = 70;

        public MainWindow()
        {
            InitializeComponent();
            CenterToScreen();
            Text = string.Format("Your Font size is: {0}", currFontSize);
            this.toolStripTextBoxMessage.LostFocus += new EventHandler(toolStripTextBoxMessage_LostFocus);
        }

        void toolStripTextBoxMessage_LostFocus(object sender, EventArgs e)
        {
            toolStripContainer1.Invalidate(true);
        }

        private void toolStripButtonShrinkFont_Click(object sender, EventArgs e)
        {
            currFontSize -= 5;
            if (currFontSize <= MinFontSize)
                currFontSize = MinFontSize;

            Text = string.Format("Your Font size is: {0}", currFontSize);
            toolStripContainer1.Invalidate(true);
        }

        private void toolStripButtonGrowFont_Click(object sender, EventArgs e)
        {
            currFontSize += 5;
            if (currFontSize >= MaxFontSize)
                currFontSize = MaxFontSize;

            Text = string.Format("Your Font size is: {0}", currFontSize);
            toolStripContainer1.Invalidate(true);
        }

        private void ContentPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawString(toolStripTextBoxMessage.Text, new Font("Times New Roman", currFontSize),
                Brushes.Black, 10, 60);
        }
    }
}
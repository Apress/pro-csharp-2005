using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MenuStripApp
{
    // Helper enum for font size.
    enum TextFontSize
    {
        FontSizeHuge = 30,
        FontSizeNormal = 20,
        FontSizeTiny = 8
    }

    public partial class MainWindow : Form
    {
        private TextFontSize currFontSize = TextFontSize.FontSizeNormal;

        // Marks the item checked.
        private ToolStripMenuItem currentCheckedItem;       

        public MainWindow()
        {
            CenterToScreen();
            InitializeComponent();

            // Now check the 'Normal' menu item.
            currentCheckedItem = normalToolStripMenuItem;
            currentCheckedItem.Checked = true;

            // Handle the LostFocus event on tool strip item.
            this.toolStripTextBoxColor.LostFocus += new EventHandler(toolStripTextBoxColor_LostFocus);
        }

        #region Event Handlers
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void toolStripTextBoxColor_LostFocus(object sender, EventArgs e)
        {
            try
            {
                BackColor = Color.FromName(toolStripTextBoxColor.Text);
            }
            catch { /* Just do nothing if they type a bogus value */}
        }

        private void ContextMenuItemSelection_Clicked(object sender, EventArgs e)
        {
            // Uncheck the currently checked item.
            currentCheckedItem.Checked = false;

            // Obtain the currently clicked ToolStripMenuItem.
            ToolStripMenuItem miClicked =
                miClicked = (ToolStripMenuItem)sender;

            // Figure out which item was clicked using it's Name.
            if (miClicked.Name == "hugeToolStripMenuItem")
            {
                currFontSize = TextFontSize.FontSizeHuge;
                currentCheckedItem = hugeToolStripMenuItem;
            }
            if (miClicked.Name == "normalToolStripMenuItem")
            {
                currFontSize = TextFontSize.FontSizeNormal;
                currentCheckedItem = normalToolStripMenuItem;

            }
            if (miClicked.Name == "tinyToolStripMenuItem")
            {
                currFontSize = TextFontSize.FontSizeTiny;
                currentCheckedItem = tinyToolStripMenuItem;

            }

            // Check new item.
            currentCheckedItem.Checked = true;

            // Tell the Form to repaint itself. 
            Invalidate();
        }

        private void MainWindow_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawString("Right click on me...",
                 new Font("Times New Roman", (float)currFontSize),
                 new SolidBrush(Color.Black), 50, 50);
        } 
        #endregion
    }
}
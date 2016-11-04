using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SimpleMdiApp
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            CenterToScreen();
            InitializeComponent();
        }

        #region Menu item event handlers.

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        { LayoutMdi(MdiLayout.Cascade); }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        { LayoutMdi(MdiLayout.TileVertical); }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        { LayoutMdi(MdiLayout.TileHorizontal); }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        { Application.Exit(); }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Make a new child window.
            ChildPrototypeForm newChild = new ChildPrototypeForm();

            // Set the Parent Form of the Child window.
            newChild.MdiParent = this;

            // Display the new form.
            newChild.Show();
        }
        #endregion
    }
}
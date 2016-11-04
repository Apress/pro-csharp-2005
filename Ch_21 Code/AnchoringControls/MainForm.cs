using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace AnchoringControls
{
	partial class AnchorForm : System.Windows.Forms.Form
    {

		public AnchorForm()
		{
			InitializeComponent();
			CenterToScreen();
		}

        #region Menu Handlers
        protected void dockNone_Click(object sender, System.EventArgs e)
        {
            btnTheButton.Dock = DockStyle.None;
            btnTheButton.Text = "Anchor: " + btnTheButton.Anchor.ToString() +
                "\nDock: " + btnTheButton.Dock.ToString();
        }

        protected void dockFill_Click(object sender, System.EventArgs e)
        {
            btnTheButton.Dock = DockStyle.Fill;
            btnTheButton.Text = "Anchor: " + btnTheButton.Anchor.ToString() +
                "\nDock: " + btnTheButton.Dock.ToString();
        }

        protected void dockRight_Click(object sender, System.EventArgs e)
        {
            btnTheButton.Dock = DockStyle.Right;
            btnTheButton.Text = "Anchor: " + btnTheButton.Anchor.ToString() +
                "\nDock: " + btnTheButton.Dock.ToString();
        }

        protected void dockLeft_Click(object sender, System.EventArgs e)
        {
            btnTheButton.Dock = DockStyle.Left;
            btnTheButton.Text = "Anchor: " + btnTheButton.Anchor.ToString() +
                "\nDock: " + btnTheButton.Dock.ToString();
        }

        protected void dockBottom_Click(object sender, System.EventArgs e)
        {
            btnTheButton.Dock = DockStyle.Bottom;
            btnTheButton.Text = "Anchor: " + btnTheButton.Anchor.ToString() +
                "\nDock: " + btnTheButton.Dock.ToString();
        }

        protected void dockTop_Click(object sender, System.EventArgs e)
        {
            btnTheButton.Dock = DockStyle.Top;
            btnTheButton.Text = "Anchor: " + btnTheButton.Anchor.ToString() +
                "\nDock: " + btnTheButton.Dock.ToString();
        }

        protected void ancRight_Click(object sender, System.EventArgs e)
        {
            btnTheButton.Anchor = AnchorStyles.Right;
            btnTheButton.Text = "Anchor: " + btnTheButton.Anchor.ToString() +
                "\nDock: " + btnTheButton.Dock.ToString();
        }

        protected void ancBottom_Click(object sender, System.EventArgs e)
        {
            btnTheButton.Anchor = AnchorStyles.Bottom;
            btnTheButton.Text = "Anchor: " + btnTheButton.Anchor.ToString() +
                "\nDock: " + btnTheButton.Dock.ToString();
        }

        protected void ancLeft_Click(object sender, System.EventArgs e)
        {
            btnTheButton.Anchor = AnchorStyles.Left;
            btnTheButton.Text = "Anchor: " + btnTheButton.Anchor.ToString() +
                "\nDock: " + btnTheButton.Dock.ToString();
        }

        protected void ancTop_Click(object sender, System.EventArgs e)
        {
            btnTheButton.Anchor = AnchorStyles.Top;
            btnTheButton.Text = "Anchor: " + btnTheButton.Anchor.ToString() +
                "\nDock: " + btnTheButton.Dock.ToString();
        }

        private void ancNone_Click(object sender, System.EventArgs e)
        {
            btnTheButton.Anchor = AnchorStyles.None;
            btnTheButton.Text = "Anchor: " + btnTheButton.Anchor.ToString() +
                "\nDock: " + btnTheButton.Dock.ToString();
        }

        private void ancTopLeft_Click(object sender, System.EventArgs e)
        {
            btnTheButton.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            btnTheButton.Text = "Anchor: " + btnTheButton.Anchor.ToString() +
                "\nDock: " + btnTheButton.Dock.ToString();
        }

        private void ancTopRight_Click(object sender, System.EventArgs e)
        {
            btnTheButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTheButton.Text = "Anchor: " + btnTheButton.Anchor.ToString() +
                "\nDock: " + btnTheButton.Dock.ToString();
        }

        private void ancBotLeft_Click(object sender, System.EventArgs e)
        {
            btnTheButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnTheButton.Text = "Anchor: " + btnTheButton.Anchor.ToString() +
                "\nDock: " + btnTheButton.Dock.ToString();
        }

        private void ancBotRight_Click(object sender, System.EventArgs e)
        {
            btnTheButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnTheButton.Text = "Anchor: " + btnTheButton.Anchor.ToString() +
                "\nDock: " + btnTheButton.Dock.ToString();
        } 
        #endregion
	}
}

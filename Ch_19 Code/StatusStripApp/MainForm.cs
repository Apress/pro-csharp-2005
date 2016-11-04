using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StatusStripApp
{
    enum DateTimeFormat
    {
        ShowClock,
        ShowDay
    }

    public partial class MainWindow : Form
    {
        // Which format to display?
        DateTimeFormat dtFormat = DateTimeFormat.ShowClock;

        // Marks the item checked.
        private ToolStripMenuItem currentCheckedItem;    

        public MainWindow()
        {
            InitializeComponent();

            // Set up Form properties.
            Text = "Status Strip Example";
            CenterToScreen();
            BackColor = Color.CadetBlue;

            currentCheckedItem = currentTimeToolStripMenuItem;
            currentCheckedItem.Checked = true;
        }

        private void timerDateTimeUpdate_Tick(object sender, EventArgs e)
        {
            string panelInfo = "";

            if (dtFormat == DateTimeFormat.ShowClock)
                panelInfo = DateTime.Now.ToLongTimeString();
            else
                panelInfo = DateTime.Now.ToLongDateString();

            toolStripStatusLabelClock.Text = panelInfo;	
        }

        private void currentTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentCheckedItem.Checked = false;
            dtFormat = DateTimeFormat.ShowClock;
            currentCheckedItem = currentTimeToolStripMenuItem;
            currentCheckedItem.Checked = true;
        }

        private void dayoftheWeekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentCheckedItem.Checked = false;
            dtFormat = DateTimeFormat.ShowDay;
            currentCheckedItem = dayoftheWeekToolStripMenuItem;
            currentCheckedItem.Checked = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("My StatusStripApp!");
        }

        #region Menu Help String Event Handlers
        private void exitToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabelMenuState.Text = "Exits the app.";
        }

        private void aboutToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabelMenuState.Text = "Shows about box.";
        }

        private void dayoftheWeekToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabelMenuState.Text = "Shows the day of the week.";
        }

        private void currentTimeToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabelMenuState.Text = "Shows the current time.";
        }

        private void SetReadyPrompt(object sender, EventArgs e)
        {
            toolStripStatusLabelMenuState.Text = "Ready.";
        } 
        #endregion
    }
}
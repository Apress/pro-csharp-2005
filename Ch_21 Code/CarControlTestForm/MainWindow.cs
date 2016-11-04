using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CarControlTestForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            myCarControl.Animate = true;
            myCarControl.Speed = 0;
            lblCurrentSpeed.Text = string.Format("Current Speed: {0}", 
                this.myCarControl.Speed.ToString());
            numericUpDownCarSpeed.Value = myCarControl.Speed;
        }

        private void numericUpDownCarSpeed_ValueChanged(object sender, EventArgs e)
        {
            // Assume the min of this upDown is 0 and max is 300.
            this.myCarControl.Speed = (int)numericUpDownCarSpeed.Value;
            lblCurrentSpeed.Text = string.Format("Current Speed: {0}",
                this.myCarControl.Speed.ToString());
        }

        private void myCarControl_AboutToBlow(string msg)
        {
            lblEventData.Text = string.Format("Event Data: {0}", msg);
        }

        private void myCarControl_BlewUp(string msg)
        {
            lblEventData.Text = string.Format("Event Data: {0}", msg);
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Resources;
using System.Reflection;

namespace MyResourcesWinApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            CenterToScreen();
            InitializeComponent();
        }

        private void btnGetStringData_Click(object sender, EventArgs e)
        {
            // Make a resoruce manager.
            ResourceManager rm =
                new ResourceManager("MyResourcesWinApp.MyCustomResources", 
                Assembly.GetExecutingAssembly());

            // Get the embedded string (case sensitive!)
            MessageBox.Show(rm.GetString("WelcomeString"));

            // Get the embedded bitmap (case sensitive!)
            myPictureBox.Image = (Bitmap)rm.GetObject("HappyDude");

            // Clean up.
            rm.ReleaseAllResources();
        }
    }
}
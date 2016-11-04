using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Resources;

namespace ResXWriter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            CenterToScreen();
            InitializeComponent();
        }

        private void btnGenResX_Click(object sender, EventArgs e)
        {
            // Make an resx writer & specify the file to write to.
            ResXResourceWriter w =
                 new ResXResourceWriter(@"C:\ResXForm.resx");
            // Add happy dude & string.
            Image i = new Bitmap("happyDude.bmp");
            w.AddResource("happyDude", i);
            w.AddResource("welcomeString", "Hello new resource format!");

            // Commit it.
            w.Generate();
            w.Close();
        }

        private void GenerateResourceFile()
        {
            // Make a new *.resources file.
            ResourceWriter rw;
            rw = new ResourceWriter(@"C:\myResources.resources");

            // Add 1 image and 1 string.
            rw.AddResource("happyDude", new Bitmap("happyDude.bmp"));
            rw.AddResource("welcomeString", "Hello new resource format!");
            rw.Generate();
            rw.Close();
        } 
    }
}
using System;
using System.Windows.Forms;
using System.Drawing;

namespace MyWindowsApp
{
    // The main window.
    public class MainWindow : Form 
    { 
        public MainWindow()
        {
            // Use inherited properties to set
            // basic UI.
            Text = "My Fantastic Form";
            Height = 300;
            Width = 500;
            BackColor = Color.LemonChiffon;
            Cursor = Cursors.Hand;

            // Handle the MouseMove event
            this.MouseMove += new MouseEventHandler(MainForm_MouseMove);

            // Handle the MouseUp event.
            this.MouseUp += new MouseEventHandler(MainForm_MouseUp);

            // Listen to KeyUp Event.
            this.KeyUp += new KeyEventHandler(MainForm_KeyUp);
        }

        protected void MainForm_MouseMove(object sender, MouseEventArgs e)
        {  
            this.Text = string.Format("Current Pos: ({0}, {1})", e.X, e.Y); 
        } 

        protected void MainForm_MouseUp(object sender, MouseEventArgs e)
        {   
            // Which mouse button was clicked?
            if(e.Button == MouseButtons.Left)
                MessageBox.Show("Left click!");
            if(e.Button == MouseButtons.Right)    
                MessageBox.Show("Right click!");
            if (e.Button == MouseButtons.Middle)
                MessageBox.Show("Middle click!");
        }

        protected void MainForm_KeyUp (object sender, KeyEventArgs e)
        { 
            MessageBox.Show(e.KeyCode.ToString(), "Key Pressed!");
        }

    }

    // The application object.
    public static class Program
    {
        public static void Main(string[] args) 
        {
            Application.Run(new MainWindow());
        }
    }
}



using System;
using System.Windows.Forms;
using System.ComponentModel;

namespace MyWindowsApp
{
    // The main window.
    public class MainWindow : Form 
    {
        private string lifeTimeInfo;

        public MainWindow()
        {
            // Handle various lifetime events.
            this.Closing += new CancelEventHandler(MainForm_Closing);
            this.Load += new EventHandler(MainForm_Load);
            this.Closed += new EventHandler(MainForm_Closed);
            this.Activated += new EventHandler(MainForm_Activated);
            this.Deactivate += new EventHandler(MainForm_Deactivate);
        }

        protected void MainForm_Closing(object sender, CancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you REALLY want to close this app?",
                 "Closing event!", MessageBoxButtons.YesNo);
            if (dr == DialogResult.No)
                e.Cancel = true;
            else
                e.Cancel = false;
        }

        protected void MainForm_Load(object sender, System.EventArgs e)
        { lifeTimeInfo += "Load event\n"; }
        protected void MainForm_Activated(object sender, System.EventArgs e)
        { lifeTimeInfo += "Activate event\n"; }
        protected void MainForm_Deactivate(object sender, System.EventArgs e)
        { lifeTimeInfo += "Deactivate event\n"; }
        protected void MainForm_Closed(object sender, System.EventArgs e)
        { 
            lifeTimeInfo += "Closed event\n"; 
            MessageBox.Show(lifeTimeInfo);
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



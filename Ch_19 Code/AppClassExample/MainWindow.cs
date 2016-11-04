using System;
using System.Windows.Forms;
using System.Reflection;

// Some attributes regarding this assembly.
[assembly:AssemblyCompany("Intertech Training")]
[assembly:AssemblyProduct("A Better Window")]
[assembly:AssemblyVersion("1.1.0.0")]

namespace MyWindowsApp
{
    // The main window.
    public class MainWindow : Form 
    { 
        public MainWindow()
        {
            MessageBox.Show(Application.ProductName,
               string.Format("This app brought to you by {0}",
               Application.CompanyName));

            // Intercept the ApplicationExit event.
            Application.ApplicationExit += new EventHandler(MainWindow_OnExit);
        }

        private void MainWindow_OnExit(object sender, EventArgs evArgs) 
        {  
            MessageBox.Show(string.Format("Form version {0} has terminated.",
                Application.ProductVersion));  
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



using System;
using System.Windows.Forms;

namespace MyWindowsApp
{
    // The main window.
    public class MainWindow : Form { }

    // The application object.
    public static class Program
    {
        public static void Main(string[] args) 
        {
            Application.Run(new MainWindow());
        }
    }
}



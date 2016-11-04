using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace CarConfig
{
    class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new MainWindow());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace AnchoringControls
{
    class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles(); 
            Application.Run(new AnchorForm());
        }
    }
}

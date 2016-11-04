using System;
using System.Drawing;
using System.Windows.Forms;

namespace ControlsByHand
{
    class MainWindow : Form
    {
        // Form widget member variables.
        private TextBox firstNameBox = new TextBox();
        private Button btnShowControls = new Button();

        public MainWindow()
        {
            // Configure Form.
            this.Text = "Simple Controls";
            this.Width = 300;
            this.Height = 200;
            CenterToScreen();

            // Add a new text box to the Form.
            firstNameBox.Text = "Hello";
            firstNameBox.Size = new Size(150, 50);
            firstNameBox.Location = new Point(10, 10);
            this.Controls.Add(firstNameBox);

            // Add a new button to the Form.
            btnShowControls.Text = "Click Me";
            btnShowControls.Size = new Size(90, 30);
            btnShowControls.Location = new Point(10, 70);
            btnShowControls.BackColor = Color.DodgerBlue;
            btnShowControls.Click +=
                new EventHandler(btnShowControls_Clicked);
            this.Controls.Add(btnShowControls);
        }

        private void btnShowControls_Clicked(object sender, EventArgs e)
        {
            // Call ToString() on each control in the 
            // Form’s Controls collection . 
            string ctrlInfo = "";
            foreach (Control c in this.Controls)
            {
                ctrlInfo += string.Format("Control: {0}\n",
                    c.ToString());
            }
            MessageBox.Show(ctrlInfo, "Controls on Form");
            
            // Now disable the Buttons.
            DisableAllButtons();
        }

        private void DisableAllButtons()
        {
            foreach (Control c in this.Controls)
            {
                if (c is Button)
                    ((Button)c).Enabled = false;
            }
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Application.Run(new MainWindow());
        }
    }
}

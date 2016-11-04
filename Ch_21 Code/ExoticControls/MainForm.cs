using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ExoticControls
{
    public partial class MainWindow : Form
    {
        // Create a new generic List to hold the Car objects.
        private List<Car> listCars = new List<Car>();

        public MainWindow()
        {
            #region Ctor prep.
            InitializeComponent();
            CenterToScreen();

            // Set initial position of each slider.
            redTrackBar.Value = 100;
            greenTrackBar.Value = 255;
            blueTrackBar.Value = 0;
            UpdateColor();

            // Fill List<> and build TreeView.
            // Add Cars to the ArrayList of Car objects.
            double offset = 0.5;
            for (int x = 0; x < 100; x++)
            {
                listCars.Add(new Car(string.Format("Car {0}", x), 10 + x));
                offset += 0.5;
                listCars[x].r = new Radio(89.0 + offset);
            }
            BuildCarTreeView(); 
            #endregion
        }

        #region TrackBar page Stuff
        protected void greenTrackBar_Scroll(object sender, System.EventArgs e)
        {
            UpdateColor();
        }

        protected void redTrackBar_Scroll(object sender, System.EventArgs e)
        {
            UpdateColor();
        }

        protected void blueTrackBar_Scroll(object sender, System.EventArgs e)
        {
            UpdateColor();
        }

        private void UpdateColor()
        {
            // Get the new color.
            Color c = Color.FromArgb(redTrackBar.Value,
                greenTrackBar.Value,
                blueTrackBar.Value);
            // Change the color in the PictureBox.
            colorBox.BackColor = c;

            // Set color label.
            lblCurrColor.Text =
                string.Format("Current color is: ({0}, {1}, {2})",
                redTrackBar.Value, greenTrackBar.Value,
                blueTrackBar.Value);
        }
        #endregion

        #region Panel Stuff
        private void btnShowPanel_Click(object sender, EventArgs e)
        {
            panelTextBoxes.Visible = true;
        }

        private void btnHidePanel_Click(object sender, EventArgs e)
        {
            panelTextBoxes.Visible = false;
        }

        private void txtNormalText_TextChanged(object sender, EventArgs e)
        {
            txtUpperText.Text = txtNormalText.Text.ToUpper();
        }
        #endregion

        #region Error Page Stuff
        private void btnGetSelections_Click(object sender, EventArgs e)
        {
            // Get info from updowns...
            lblCurrSel.Text =
                string.Format("String: {0}\nNumber: {1}",
                 domainUpDown.Text,
                 numericUpDown.Value);
        }

        private void txtInput_Validating(object sender, CancelEventArgs e)
        {
            // Check if the text length is greater than 5.
            if (txtInput.Text.Length > 5)
            {
                tooManyCharactersErrorProvider.SetError(txtInput, "Can't be greater than 5!");
            }
            else // Things are OK, don't show anything.
                tooManyCharactersErrorProvider.SetError(txtInput, "");

        }
        #endregion

        #region Tree View Stuff
        private void BuildCarTreeView()
        {

            // Don’t repaint the TreeView until all the nodes have been created.
            treeViewCars.BeginUpdate();

            // Clear the TreeView each time the method is called.
            treeViewCars.Nodes.Clear();

            // Add a root TreeNode for each Car object in the List<>.
            foreach (Car c in listCars)
            {
                // Add the current Car as a top-most node.
                treeViewCars.Nodes.Add(new TreeNode(c.petName, 0, 0));

                // Now, get the Car you just added to build 
                // two sub-nodes based on the speed and 
                // internal Radio object.
                treeViewCars.Nodes[listCars.IndexOf(c)].Nodes.Add(
                    new TreeNode(string.Format("Speed: {0}", 
                    c.currSp.ToString()), 1, 1));
                treeViewCars.Nodes[listCars.IndexOf(c)].Nodes.Add(
                  new TreeNode(string.Format("Favorite Station: {0} FM", 
                  c.r.favoriteStation), 2, 2));
            }

            // Now paint the TreeView.
            treeViewCars.EndUpdate();
        }

        private void treeViewCars_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string nodeInfo = "";
            // Build info about selected node.
            nodeInfo = string.Format("You selected: {0}\n", e.Node.Text);

            if (e.Node.Parent != null)
                nodeInfo += string.Format("Parent Node: {0}\n", e.Node.Parent.Text);
            if (e.Node.NextNode != null)
                nodeInfo += string.Format("Next Node: {0}", e.Node.NextNode.Text);

            // Show info and highlight node.
            lblNodeInfo.Text = nodeInfo;
            e.Node.BackColor = Color.AliceBlue;
        }
        #endregion
        
        #region Web Broswer Stuff
        private void btnGO_Click(object sender, EventArgs e)
        {
            // Set URL based on value within page’s TextBox control.
            myWebBrowser.Url = new System.Uri(txtUrl.Text);
        }
        #endregion
    }
}
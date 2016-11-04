using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using CarsSalesInfoClient.localhost;

namespace CarsSalesInfoClient
{
    public partial class MainWindow : Form
    {
        private CarSalesInfoWS ws = new CarSalesInfoWS();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            // Bind DataSet to grid.
            inventoryDataGridView.DataSource 
                = ws.GetCurrentInventory().Tables[0];
        }

        private void btnGetTagLines_Click(object sender, EventArgs e)
        {
            string[] tagLines = ws.GetSalesTagLines();
            foreach (string tag in tagLines)
                listBoxTags.Items.Add(tag);
        }

        private void btnGetAllDetails_Click(object sender, EventArgs e)
        {
            SalesInfoDetails[] theSkinny = ws.GetSalesInfoDetails();
            foreach (SalesInfoDetails s in theSkinny)
            {
                string d = string.Format("Info: {0}\nURL:{1}\nExpiration Date:{2}",
                    s.info, s.Url, s.dateExpired);
                MessageBox.Show(d, "Details");
            }
        }
    }
}
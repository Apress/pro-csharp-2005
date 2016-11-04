using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace MultitabledDataSetApp
{
    public partial class MainForm : Form
    {
        // Form wide DataSet.
        private DataSet carsDS = new DataSet("CarsDataSet");

        // Make use of command builders to simplify data adapter configuration.
        private SqlCommandBuilder sqlCBInventory;
        private SqlCommandBuilder sqlCBCustomers;
        private SqlCommandBuilder sqlCBOrders;

        // Our data adapters (for each table).
        private SqlDataAdapter invTableAdapter;
        private SqlDataAdapter custTableAdapter;
        private SqlDataAdapter ordersTableAdapter;

        // Form wide connection object.
        private SqlConnection cn = 
            new SqlConnection("server=(local);uid=sa;pwd=;database=Cars");

        public MainForm()
        {
            InitializeComponent();

            // Create adapters.
            invTableAdapter = new SqlDataAdapter("Select * from Inventory", cn);
            custTableAdapter = new SqlDataAdapter("Select * from Customers", cn);
            ordersTableAdapter = new SqlDataAdapter("Select * from Orders", cn);

            // Autogenerate commands.
            sqlCBInventory = new SqlCommandBuilder(invTableAdapter);
            sqlCBOrders = new SqlCommandBuilder(ordersTableAdapter);
            sqlCBCustomers = new SqlCommandBuilder(custTableAdapter);

            // Add tables to DS.
            invTableAdapter.Fill(carsDS, "Inventory");
            custTableAdapter.Fill(carsDS, "Customers");
            ordersTableAdapter.Fill(carsDS, "Orders");

            // Build relations between tables.
            BuildTableRelationship();

            // Bind to grids
            dataGridViewInventory.DataSource = carsDS.Tables["Inventory"];
            dataGridViewCustomers.DataSource = carsDS.Tables["Customers"];
            dataGridViewOrders.DataSource = carsDS.Tables["Orders"];
        }


        private void BuildTableRelationship()
        {
            // Create CustomerOrder data relation object.
            DataRelation dr = new DataRelation("CustomerOrder",
                 carsDS.Tables["Customers"].Columns["CustID"],
                 carsDS.Tables["Orders"].Columns["CustID"]);
            carsDS.Relations.Add(dr);

            // Create InventoryOrder data relation object.
            dr = new DataRelation("InventoryOrder",
                 carsDS.Tables["Inventory"].Columns["CarID"],
                 carsDS.Tables["Orders"].Columns["CarID"]);
            carsDS.Relations.Add(dr);
        } 

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                invTableAdapter.Update(carsDS, "Inventory");
                custTableAdapter.Update(carsDS, "Customers");
                ordersTableAdapter.Update(carsDS, "Orders");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGetInfo_Click(object sender, System.EventArgs e)
        {
            string strInfo = "";
            DataRow drCust = null;
            DataRow[] drsOrder = null;

            // Get the specified CustID from the TextBox.
            int theCust = int.Parse(this.txtCustID.Text);
            
            // Now based on CustID, get the correct row in Customers table.
            drCust = carsDS.Tables["Customers"].Rows[theCust];
            strInfo += "Cust #" + drCust["CustID"].ToString() + "\n";
            
            // Navigate from customer table to order table.
            drsOrder = drCust.GetChildRows(carsDS.Relations["CustomerOrder"]);
            
            // Get order number.
            foreach (DataRow r in drsOrder)
                strInfo += "Order Number: " + r["OrderID"] + "\n";
            
            // Now navigate from order table to inventory table.
            DataRow[] drsInv =
                 drsOrder[0].GetParentRows(carsDS.Relations["InventoryOrder"]);
            
            // Get Car info.
            foreach (DataRow r in drsInv)
            {
                strInfo += "Make: " + r["Make"] + "\n";
                strInfo += "Color: " + r["Color"] + "\n";
                strInfo += "Pet Name: " + r["PetName"] + "\n";
            }
            MessageBox.Show(strInfo, "Info based on cust ID");
        }
    }
}
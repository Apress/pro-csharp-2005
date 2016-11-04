using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CarDataSetViewer
{
    public partial class MainForm : Form
    {
        // Our list of Cars.
        private List<Car> arTheCars = new List<Car>();

        // Our DataTable.
        private DataTable inventoryTable = new DataTable("Inventory");

        // View of the DataTable.
        DataView coltsOnlyView;      // I only show red colts.

        public MainForm()
        {
            InitializeComponent();
            CenterToScreen();

            // Fill the list with some cars.
            arTheCars.Add(new Car("Chucky", "BMW", "Green"));
            arTheCars.Add(new Car("Tiny", "Yugo", "White"));
            arTheCars.Add(new Car("", "Jeep", "Tan"));
            arTheCars.Add(new Car("Pain Inducer", "Caravan", "Pink"));
            arTheCars.Add(new Car("Fred", "BMW", "Pea Soup Green"));
            arTheCars.Add(new Car("Buddha", "BMW", "Black"));
            arTheCars.Add(new Car("Mel", "Firebird", "Red"));
            arTheCars.Add(new Car("Sarah", "Colt", "Black"));

            CreateDataTable();
            // Make Views.
            CreateDataView();
        }

        #region CreateDataTable helper
        private void CreateDataTable()
        {
            // Create DataColumns and add to DataTable.
            #region Make DataColumn objects
            // Create data columns which map to the 
            // 'real' columns in the Inventory table 
            // of the Cars database. 
            DataColumn carIDColumn = new DataColumn("CarID", typeof(int));
            carIDColumn.ReadOnly = true;
            carIDColumn.Caption = "Car ID";
            carIDColumn.AllowDBNull = false;
            carIDColumn.Unique = true;
            carIDColumn.AutoIncrement = true;
            carIDColumn.AutoIncrementSeed = 0;
            carIDColumn.AutoIncrementStep = 1;
            carIDColumn.ColumnMapping = MappingType.Attribute;

            DataColumn carMakeColumn = new DataColumn("Make", typeof(string));
            DataColumn carColorColumn = new DataColumn("Color", typeof(string));
            DataColumn carPetNameColumn = new DataColumn("PetName", typeof(string));
            carPetNameColumn.Caption = "Pet Name";
            #endregion

            // Now add DataColumns to a DataTable.
            inventoryTable.Columns.AddRange(new DataColumn[] { carIDColumn, carMakeColumn, carColorColumn, carPetNameColumn });

            // Mark the primary key of this table.
            inventoryTable.PrimaryKey = new DataColumn[] { inventoryTable.Columns[0] };

            // Iterate over the array list to make rows.
            foreach (Car c in arTheCars)
            {
                DataRow newRow = inventoryTable.NewRow();
                newRow["Make"] = c.carMake;
                newRow["Color"] = c.carColor;
                newRow["PetName"] = c.carPetName;
                inventoryTable.Rows.Add(newRow);
            }

            // Bind the DataTable to the carInventoryGridView.
            carInventoryGridView.DataSource = inventoryTable;
        } 
        #endregion

        #region CreateDataView helper
        private void CreateDataView()
        {
            // Set the table that is used to construct this view.
            coltsOnlyView = new DataView(inventoryTable);

            // Now configure the views using a filter.
            coltsOnlyView.RowFilter = "Make = 'Colt'";

            // Bind to grids.
            dataGridColtsView.DataSource = coltsOnlyView;
        }
        #endregion 

        #region Event Handlers
        private void btnRemoveRow_Click(object sender, EventArgs e)
        {
            try
            {
                inventoryTable.Rows[(int.Parse(txtRowToRemove.Text))].Delete();
                inventoryTable.AcceptChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGetMakes_Click(object sender, EventArgs e)
        {
            // Build a filter based on user input.
            string filterStr = string.Format("Make= '{0}' ", txtMakeToGet.Text);

            // Find all rows matching the filter.
            DataRow[] makes = inventoryTable.Select(filterStr, "PetName DESC");

            // Show what we got!
            if (makes.Length == 0)
                MessageBox.Show("Sorry, no cars...", "Selection error!");
            else
            {
                string strMake = null;
                for (int i = 0; i < makes.Length; i++)
                {
                    DataRow temp = makes[i];
                    strMake += temp["PetName"] + "\n";
                }
                MessageBox.Show(strMake, txtMakeToGet.Text + " type(s):");
            }
        }

        private void btnChangeBeemersToColts_Click(object sender, EventArgs e)
        {
            // Make sure user has not lost their mind.
            if (DialogResult.Yes ==
                MessageBox.Show("Are you sure?? BMWs are much nicer than Colts!",
                "Please Confirm!", MessageBoxButtons.YesNo))
            {

                // Build a filter.
                string filterStr = "Make='BMW'";
                string strMake = null;

                // Find all rows matching the filter.
                DataRow[] makes = inventoryTable.Select(filterStr);

                // Change all Beemers to Colts!
                for (int i = 0; i < makes.Length; i++)
                {
                    DataRow temp = makes[i];
                    strMake += temp["Make"] = "Colt";
                    makes[i] = temp;
                }
            }
        } 
        #endregion

        private void ShowCarsWithIdLessThanFive()
        {
            // Now show the pet names of all cars with ID greater than 5.
            DataRow[] properIDs;
            string newFilterStr = "ID > '5'";
            properIDs = inventoryTable.Select(newFilterStr);
            string strIDs = null;
            for (int i = 0; i < properIDs.Length; i++)
            {
                DataRow temp = properIDs[i];
                strIDs += temp["PetName"]
                    + " is ID " + temp["ID"] + "\n";
            }
            MessageBox.Show(strIDs, "Pet names of cars where ID > 5");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace SimpleDataSet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with DataSets *****\n");

            // Create the DataSet object.
            DataSet carsInventoryDS = new DataSet("Car Inventory");
            carsInventoryDS.ExtendedProperties["TimeStamp"] = DateTime.Now;
            carsInventoryDS.ExtendedProperties["Company"] = "Intertech Training";

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
            DataTable inventoryTable = new DataTable("Inventory");
            inventoryTable.Columns.AddRange(new DataColumn[] 
                { carIDColumn, carMakeColumn, carColorColumn, carPetNameColumn });

            // Mark the primary key of this table.
            inventoryTable.PrimaryKey = new DataColumn[] { inventoryTable.Columns[0] };

            #region Add Rows to DataTable
            // Now add some rows to the Inventory Table. 
            DataRow carRow = inventoryTable.NewRow();
            carRow["Make"] = "BMW";
            carRow["Color"] = "Black";
            carRow["PetName"] = "Hamlet";
            inventoryTable.Rows.Add(carRow);
            carRow = inventoryTable.NewRow();
            carRow["Make"] = "Saab";
            carRow["Color"] = "Red";
            carRow["PetName"] = "Sea Breeze";
            inventoryTable.Rows.Add(carRow); 
            #endregion

            // Finally, add our table to the DataSet.
            carsInventoryDS.Tables.Add(inventoryTable);

            // Print the DataSet
            PrintDataSet(carsInventoryDS);

            // Print out the DataTable via 'table reader'.
            PrintTable(carsInventoryDS.Tables["Inventory"]);

            // Save this DataSet as XML.
            carsInventoryDS.WriteXml("carsDataSet.xml");
            carsInventoryDS.WriteXmlSchema("carsDataSet.xsd");

            // Clear out the DataSet and reload from XML.
            carsInventoryDS.Clear();

            // Print the DataSet (will be empty)
            PrintDataSet(carsInventoryDS);

            carsInventoryDS.ReadXml("carsDataSet.xml");
            PrintDataSet(carsInventoryDS);

            Console.WriteLine();
        }

        #region PrintDataSet helper function
        static void PrintDataSet(DataSet ds)
        {
            Console.WriteLine("Tables in '{0}' DataSet.\n", ds.DataSetName);

            foreach (DataTable dt in ds.Tables)
            {
                Console.WriteLine("{0} Table.\n", dt.TableName);

                // Print out the column names.
                for (int curCol = 0; curCol < dt.Columns.Count; curCol++)
                {
                    Console.Write(dt.Columns[curCol].ColumnName.Trim() + "\t");
                }
                Console.WriteLine("\n----------------------------------");

                // Print the DataTable.
                for (int curRow = 0; curRow < dt.Rows.Count; curRow++)
                {
                    for (int curCol = 0; curCol < dt.Columns.Count; curCol++)
                    {
                        Console.Write(dt.Rows[curRow][curCol].ToString().Trim() + "\t");
                    }
                    Console.WriteLine();
                }
            }
        } 
        #endregion

        #region PrintTable helper function
        private static void PrintTable(DataTable dt)
        {
            Console.WriteLine("\n***** Rows in DataTable *****");

            // Now, get the new .NET 2.0 DataTableReader type.
            DataTableReader dtReader = dt.CreateDataReader();

            // The DataTableReader works just like the DataReader.
            while (dtReader.Read())
            {
                for (int i = 0; i < dtReader.FieldCount; i++)
                {
                    Console.Write("{0} = {1} ",
                        dtReader.GetName(i).Trim(),
                        dtReader.GetValue(i).ToString().Trim());
                }
                Console.WriteLine();
            }
            dtReader.Close();
        } 
        #endregion
    }
}

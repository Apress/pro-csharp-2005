using System;
using System.Collections.Generic;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

namespace FillDataSetWithSqlDataAdapter 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Data Adapters *****\n");

            // Ideally we'd read this from a *.config file.
            string cnStr = "uid=sa;pwd=;Initial Catalog=Cars;Data Source=(local)";

            // Fill the DataSet with a new DataTable.
            DataSet myDS = new DataSet("Cars");
            SqlDataAdapter dAdapt = new SqlDataAdapter("Select * From Inventory", cnStr);

            // Create table mappings.
            DataTableMapping custMap = dAdapt.TableMappings.Add("Inventory", "Current Inventory");
            custMap.ColumnMappings.Add("CarID", "Car ID");
            custMap.ColumnMappings.Add("PetName", "Name of Car");

            try
            {
                dAdapt.Fill(myDS, "Inventory");   
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            // Display contents.
            PrintDataSet(myDS);
        }

        #region PrintDataSet method.
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
    }
}

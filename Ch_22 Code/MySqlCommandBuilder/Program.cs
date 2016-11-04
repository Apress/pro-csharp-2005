using System;
using System.Collections.Generic;
using System.Text;

using System.Data;
using System.Data.SqlClient; 

namespace MySqlCommandBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            DataSet theCarsInventory = new DataSet();

            // Make connection.
            SqlConnection cn = new
                SqlConnection("server=(local);User ID=sa;Pwd=;database=Cars");
            
            // Autogenerate INSERT, UPDATE, and DELETE commands
            // based on exiting SELECT command.
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Inventory", cn);
            SqlCommandBuilder invBuilder = new SqlCommandBuilder(da);

            // Fill data set.
            da.Fill(theCarsInventory, "Inventory");
            PrintDataSet(theCarsInventory);

            // Delete row based on user input and update database.
            try
            {
                Console.Write("Row # to delete: ");
                int rowToDelete = int.Parse(Console.ReadLine());
                theCarsInventory.Tables["Inventory"].Rows[rowToDelete].Delete();
                da.Update(theCarsInventory, "Inventory");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            // Refill and reprint Inventory table.
            theCarsInventory = new DataSet();
            da.Fill(theCarsInventory, "Inventory");
            PrintDataSet(theCarsInventory);
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

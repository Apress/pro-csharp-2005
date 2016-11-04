using System;
using System.Collections.Generic;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

namespace CarsDataReader
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Data Readers *****\n");

            #region Connection object code
            // Create a connection string via the builder object.
            SqlConnectionStringBuilder cnStrBuilder =
                new SqlConnectionStringBuilder();
            cnStrBuilder.UserID = "sa";
            cnStrBuilder.Password = "";
            cnStrBuilder.InitialCatalog = "Cars";
            cnStrBuilder.DataSource = "(local)";
            cnStrBuilder.ConnectTimeout = 5;

            // Create and open a connection.
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = cnStrBuilder.ConnectionString;
            cn.Open();
            ShowConnectionStatus(cn); 
            #endregion

            // Create a SQL command object.
            string strSQL = "SELECT * FROM Inventory";
            SqlCommand myCommand = new SqlCommand(strSQL, cn);

            #region Data reader code
            // Obtain a data reader ala ExecuteReader().
            SqlDataReader myDataReader;
            myDataReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection);

            // Loop over the results.
            while (myDataReader.Read())
            {
                for (int i = 0; i < myDataReader.FieldCount; i++)
                {
                    Console.Write("{0} = {1} ",
                        myDataReader.GetName(i),
                        myDataReader.GetValue(i).ToString().Trim());
                }
                Console.WriteLine();
            }          
            #endregion
            
            Console.WriteLine();

            // Because we specified CommandBehavior.CloseConnection, we 
            // don't need to explicitly call Close() on the connection.
            myDataReader.Close();
            ShowConnectionStatus(cn);
        }

        private static void ShowConnectionStatus(DbConnection cn)
        {
            // Show various stats about current connection object.
            Console.WriteLine("***** Info about your connection *****");
            Console.WriteLine("Database location: {0}", cn.DataSource);
            Console.WriteLine("Database name: {0}", cn.Database);
            Console.WriteLine("Timeout: {0}", cn.ConnectionTimeout);
            Console.WriteLine("Connection state: {0}\n", cn.State.ToString());
        }
    }
}

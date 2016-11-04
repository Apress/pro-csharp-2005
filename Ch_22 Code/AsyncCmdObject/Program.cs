using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

using System.Runtime.Remoting.Messaging;
using System.Threading;

namespace AsyncCmdObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with ASNYC Data Readers *****\n");

            // Create an open a connection which is async-aware.
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString =
              "uid=sa;pwd=;Initial Catalog=Cars;" +
              "Asynchronous Processing=true;Data Source=(local)";
            cn.Open();

            // Create a SQL command object.
            string strSQL = "WaitFor Delay '00:00:02';Select * From Inventory";
            SqlCommand myCommand = new SqlCommand(strSQL, cn);

            // Execute the reader on a second thread. 
            IAsyncResult itfAsynch;
            itfAsynch = myCommand.BeginExecuteReader(CommandBehavior.CloseConnection);

            // Do something while other thread works. 
            while (!itfAsynch.IsCompleted)
            {
	            Console.WriteLine("Working on main thread...");
                Thread.Sleep(1000);
            }
            Console.WriteLine();

            // Loop over the results.
            SqlDataReader myDataReader = myCommand.EndExecuteReader(itfAsynch);
            while (myDataReader.Read())
            {
                Console.WriteLine("-> Make: {0}, PetName: {1}, Color: {2}.",
                  myDataReader["Make"].ToString().Trim(),
                  myDataReader["PetName"].ToString().Trim(),
                  myDataReader["Color"].ToString().Trim());
            }

            // Because we specified CommandBehavior.CloseConnection, we 
            // don't need to explicitly call Close() on the connection.
            myDataReader.Close();
        }
    }
}

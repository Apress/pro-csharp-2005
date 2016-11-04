using System;
using System.Collections.Generic;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data.Odbc;
using System.Data.OracleClient;
using System.Configuration;

namespace MyConnectionFactory
{
    enum DataProvider
	{ SqlServer, OleDb, Odbc, Oracle }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********************************************************");
            Console.WriteLine("***** This App does not do anything really useful. *****");
            Console.WriteLine("***** However it illustrates how one might build a *****");
            Console.WriteLine("*****     custom ADO.NET data provider factory     *****");
            Console.WriteLine("********************************************************\n");

            // Read the DataProvider key.
            string dpStr = ConfigurationManager.AppSettings["provider"];
            DataProvider dp = (DataProvider)Enum.Parse(typeof(DataProvider), dpStr);

            // Read the connection string.
            string cnStr = ConfigurationManager.AppSettings["cnStr"];

            // Get a specific connection.
            IDbConnection myCn = GetConnection(dp);
            myCn.ConnectionString = cnStr;

            // Now open it via our helper function.
            OpenConnection(myCn);

            // Use it and close when finished.
            myCn.Close();
        }

        #region Helper methods
        static IDbConnection GetConnection(DataProvider dp)
        {
            IDbConnection conn = null;
            switch (dp)
            {
                case DataProvider.SqlServer:
                    conn = new SqlConnection();
                    break;
                case DataProvider.OleDb:
                    conn = new OleDbConnection();
                    break;
                case DataProvider.Odbc:
                    conn = new OdbcConnection();
                    break;
                case DataProvider.Oracle:
                    conn = new OracleConnection();
                    break;
            }
            return conn;
        }

        public static void OpenConnection(IDbConnection cn)
        {
            // Open the incoming connection for the caller.
            cn.Open();
        }  
        #endregion
    }
}

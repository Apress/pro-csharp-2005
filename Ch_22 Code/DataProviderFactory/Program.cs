using System;
using System.Collections.Generic;
using System.Text;

using System.Data;
using System.Data.Common;
using System.Configuration;

namespace DataProviderFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Data Provider Factories *****\n");

            // Get Connection string / provider from *.config.
            string dp =
              ConfigurationManager.AppSettings["provider"];
            string cnStr =
              ConfigurationManager.ConnectionStrings["SqlProviderPubs"].ConnectionString;

            // Make the factory provider.
            DbProviderFactory df = DbProviderFactories.GetFactory(dp);

            // Now make connection object.
            DbConnection cn = df.CreateConnection();
            Console.WriteLine("Your connection object is a: {0}", cn.GetType().FullName);
            cn.ConnectionString = cnStr;
            cn.Open();

            // Make command object.
            DbCommand cmd = df.CreateCommand();
            Console.WriteLine("Your command object is a: {0}", cmd.GetType().FullName);
            cmd.Connection = cn;
            cmd.CommandText = "Select * From Authors";

            // Print out data with data reader.
            DbDataReader dr =
              cmd.ExecuteReader(CommandBehavior.CloseConnection);
            Console.WriteLine("Your data reader object is a: {0}", dr.GetType().FullName);

            Console.WriteLine("\n***** Authors in Pubs *****");

            while (dr.Read())
                Console.WriteLine("-> {0}, {1}", dr["au_lname"], dr["au_fname"]);
            dr.Close();
        }
    }
}

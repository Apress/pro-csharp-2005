using System;
using System.Collections.Generic;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace CarsInvertoryUpdaterDS
{
    class Program
    {
        // The applicaion wide DataSet.
        public static DataSet dsCarInventory = new DataSet("CarsDatabase");

        // The application wide connection object.
        public static SqlConnection cnObj = new SqlConnection("uid=sa;pwd=;Initial Catalog=Cars;Data Source=(local)");

        static void Main(string[] args)
        {
            Console.WriteLine("***** Car Inventory Updater (with DataSets) *****");
            bool userDone = false;
            string userCommand = "";

            // Create the adapter.
            SqlDataAdapter dAdapter = new SqlDataAdapter("Select * From Inventory", cnObj);

            // Fill the DataSet.
            dAdapter.Fill(dsCarInventory, "Inventory");

            ShowInstructions();

            #region Get User Command
            do
            {
                Console.Write("Please enter your command: ");
                userCommand = Console.ReadLine();
                Console.WriteLine();

                switch (userCommand.ToUpper())
                {
                    case "I":
                        InsertNewCar(dAdapter);
                        break;
                    case "U":
                        UpdateCarPetName(dAdapter);
                        break;
                    case "D":
                        DeleteCar(dAdapter);
                        break;
                    case "L":
                        ListInventory(dAdapter);
                        break;
                    case "S":
                        ShowInstructions();
                        break;
                    case "Q":
                        userDone = true;
                        break;
                    default:
                        Console.WriteLine("Bad data!  Try again");
                        break;
                }
            } while (!userDone);
            #endregion

            Console.WriteLine("Your connection state is: {0}", cnObj.State);
        }

        #region DeleteCar method.
        private static void DeleteCar(SqlDataAdapter dAdpater)
        {
            // Get ID of car to delete, then do so.
            int carToDelete = 0;
            Console.Write("Enter CarID of car to delete: ");
            try
            {
                carToDelete = int.Parse(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            string sql = string.Format("Delete from Inventory where CarID = '{0}'",
                carToDelete);
            SqlCommand cmd = new SqlCommand(sql, cnObj);
            dAdpater.DeleteCommand = cmd;

            DataRow[] carRowToDelete =
                dsCarInventory.Tables["Inventory"].Select(string.Format("CarID = '{0}'", carToDelete));
            carRowToDelete[0].Delete();

            try
            {
                dAdpater.Update(dsCarInventory.Tables["Inventory"]);
            }
            catch
            {
                Console.WriteLine("Sorry!  Error!  Canceling request");
            }
        }
        #endregion

        #region UpdateCarPetName method
        private static void UpdateCarPetName(SqlDataAdapter dAdpater)
        {
            int carToUpdate = 0;
            string newPetName = "";

            Console.Write("Enter CarID of car to modify: ");
            try
            {
                carToUpdate = int.Parse(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            Console.Write("Enter new pet name: ");
            newPetName = Console.ReadLine();

            string sql = string.Format("Update Inventory Set PetName = '{0}' Where CarID = '{1}'",
                newPetName, carToUpdate);
            SqlCommand cmd = new SqlCommand(sql, cnObj);
            dAdpater.UpdateCommand = cmd;

            DataRow[] carRowToUpdate = 
                dsCarInventory.Tables["Inventory"].Select(string.Format("CarID = '{0}'", carToUpdate));
            carRowToUpdate[0]["PetName"] = newPetName;

            try
            {
                dAdpater.Update(dsCarInventory.Tables["Inventory"]);
            }
            catch
            {
                Console.WriteLine("Sorry!  Error!  Canceling request");
            }
        }
        #endregion

        #region InsertNewCar method.
        private static void InsertNewCar(SqlDataAdapter dAdpater)
        {
            // Gather info about new car.
            Console.Write("Enter CarID: ");
            int newCarID = 0;
            try
            {
                newCarID = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Bad input!  Canceling request");
                return;
            }
            Console.Write("Enter Make: ");
            string newCarMake = Console.ReadLine();
            Console.Write("Enter Color: ");
            string newCarColor = Console.ReadLine();
            Console.Write("Enter PetName: ");
            string newCarPetName = Console.ReadLine();

            // Format SQL Insert and plug into DataAdapter.
            string sql = string.Format("Insert Into Inventory" +
                "(CarID, Make, Color, PetName) Values" +
                "('{0}', '{1}', '{2}', '{3}')", 
                newCarID, newCarMake, newCarColor, newCarPetName);
            dAdpater.InsertCommand = new SqlCommand(sql);
            dAdpater.InsertCommand.Connection = cnObj;

            // Update Inventory Table with new row.
            DataRow newCar = dsCarInventory.Tables["Inventory"].NewRow();
            newCar["CarID"] = newCarID;
            newCar["Make"] = newCarMake;
            newCar["Color"] = newCarColor;
            newCar["PetName"] = newCarPetName;
            dsCarInventory.Tables["Inventory"].Rows.Add(newCar);

            try
            {
                dAdpater.Update(dsCarInventory.Tables["Inventory"]);
            }
            catch
            {
                Console.WriteLine("Sorry!  Error!  Canceling request");
            }
        }
        #endregion

        #region ListInventory method.
        private static void ListInventory(SqlDataAdapter dAdapter)
        {
            // Now, get the new .NET 2.0 DataTableReader type.
            DataTableReader dtReader = 
                dsCarInventory.Tables["Inventory"].CreateDataReader();
            
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

        #region ShowInstructions method
        private static void ShowInstructions()
        {
            Console.WriteLine();
            Console.WriteLine("I: Inserts a new car.");
            Console.WriteLine("U: Updated an existing car.");
            Console.WriteLine("D: Deletes an existing car.");
            Console.WriteLine("L: List current inventory.");
            Console.WriteLine("S: Show these instructions.");
            Console.WriteLine("Q: Quits program.");
        }
        #endregion
    }
}

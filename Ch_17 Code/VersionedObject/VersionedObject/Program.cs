using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace VersionedObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Versioned Objects *****");

            //UserPrefs up = new UserPrefs();
            //up.BackgroundColor = ConsoleColor.DarkBlue;
            //up.ForegroundColor = ConsoleColor.White;

            //// Save an instance of UserPrefs to file.
            //BinaryFormatter binFormat = new BinaryFormatter();
            //Stream fStream = new FileStream(@"C:\user.dat",
            //        FileMode.Create, FileAccess.Write, FileShare.None);
            //binFormat.Serialize(fStream, up);
            //fStream.Close();
            //Console.ReadLine();

            UserPrefs up = null;
            // Load an instance of UserPrefs (1.0) to memory?
            BinaryFormatter binFormat = new BinaryFormatter();
            Stream fStream = new FileStream(@"C:\user.dat",
                    FileMode.Open, FileAccess.Read, FileShare.None);
            up = (UserPrefs)binFormat.Deserialize(fStream);
            fStream.Close();
            Console.ReadLine();
        }
    }
}

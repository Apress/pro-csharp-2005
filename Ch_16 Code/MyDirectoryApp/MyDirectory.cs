using System;
using System.IO;

namespace FileManipulation
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("***** Fun with Directory(Info) *****\n");

            // Create a new DirectoryInfo object.
            // ----> CHANGE YOUR PATH IF NEEDED <----
            DirectoryInfo dir = new DirectoryInfo(@"C:\Windows");

            // Dump directory information.
            Console.WriteLine("***** Directory Info *****");
            Console.WriteLine("FullName: {0}", dir.FullName);
            Console.WriteLine("Name: {0}", dir.Name);
            Console.WriteLine("Parent: {0}", dir.Parent);
            Console.WriteLine("Creation: {0}", dir.CreationTime);
            Console.WriteLine("Attributes: {0}", dir.Attributes);
            Console.WriteLine("Root: {0}", dir.Root);
            Console.WriteLine("**************************\n");

            #region List stats on all *.bmp files.
            // Examine the contents of the D drive,
            // and look for bitmap files.
            FileInfo[] bitmapFiles = dir.GetFiles("*.bmp");

            Console.WriteLine("Found {0} *.bmp files\n", bitmapFiles.Length);

            foreach (FileInfo f in bitmapFiles)
            {
                // Now print out info for the file.
                Console.WriteLine("***************************\n");
                Console.WriteLine("File name: {0}", f.Name);
                Console.WriteLine("File size: {0}", f.Length);
                Console.WriteLine("Creation: {0}", f.CreationTime);
                Console.WriteLine("Attributes: {0}", f.Attributes);
                Console.WriteLine("***************************\n");
            }
            #endregion

            #region Create directories.
            // Now make a new directory on the root:
            // Create \MyFoo
            DirectoryInfo d = dir.CreateSubdirectory("MyFoo");
            Console.WriteLine("Created: {0}", d.FullName);

            // Create \MyBar\MyQaaz
            d = dir.CreateSubdirectory(@"MyBar\MyQaaz");
            Console.WriteLine("Created: {0}", d.FullName);
            #endregion

            #region list all drives and delete subdirectories we just made.
            // Now call some static members...

            // Get all drives.
            string[] drives = Directory.GetLogicalDrives();
            Console.WriteLine("Here are your drives:");
            foreach (string s in drives)
                Console.WriteLine("--> {0}", s);

            // Now delete what we made.
            Console.WriteLine("Press Enter to delete directories");
            Console.ReadLine();

            // Blow em away...
            // ----> CHANGE YOUR PATH IF NEEDED <----
            try
            {
                Directory.Delete(@"C:\Windows\MyFoo");
                Directory.Delete(@"C:\Windows\MyBar", true);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            #endregion

            Console.ReadLine();
        }
    }
}

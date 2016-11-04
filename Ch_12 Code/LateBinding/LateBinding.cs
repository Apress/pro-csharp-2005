using System;
using System.Reflection;
using System.IO;

namespace LateBinding
{
	public class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("***** The Late Binding App *****\n");

            // Try to load a local copy of CarLibrary.
            Assembly a = null;
			try
			{
				a = Assembly.Load("CarLibrary");
			}
			catch(FileNotFoundException e)
			{
                Console.WriteLine(e.Message);
                Console.ReadLine();
                return;
            }
		
			// Get the Minivan type.
			Type miniVan = a.GetType("CarLibrary.MiniVan");

			// Create the Minivan on the fly.
			object obj = Activator.CreateInstance(miniVan);
		
			// Get info for TurnOnRadio.
			MethodInfo mi = miniVan.GetMethod("TurboBoost");

			// Invoke method.
			mi.Invoke(obj, null);

			// Create array of params.
			object[] paramArray = new object[2];		
			paramArray[0] = "Fred";
			paramArray[1] = 4;
			mi = miniVan.GetMethod("TellChildToBeQuiet");
			mi.Invoke(obj, paramArray);
            Console.WriteLine("All done!");
            Console.ReadLine();
        }
	}
}


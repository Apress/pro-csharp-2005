using System;
using System.Reflection;
using System.Windows.Forms;
	
namespace AppDomainManipulator
{
	public class ExerciseAppDomain
	{
		#region print asms in AD helper f(x)
		public static void PrintAllAssembliesInAppDomain(AppDomain ad)
		{
			Assembly[] loadedAssemblies = ad.GetAssemblies();			
			Console.WriteLine("***** Here are the assemblies loaded in {0} *****\n",
				ad.FriendlyName);
			foreach(Assembly a in loadedAssemblies)
			{
				Console.WriteLine("-> Name: {0}", a.GetName().Name);
				Console.WriteLine("-> Version: {0}\n", a.GetName().Version);
			}
		}
		#endregion 

		#region AppDomain event handlers
		public static void anotherAD_DomainUnload(object sender, EventArgs e)
		{
			Console.WriteLine("***** Unloaded anotherAD! *****\n");
		}
		private static void defaultAD_ProcessExit(object sender, EventArgs e)
		{
			Console.WriteLine("***** Unloaded defaultAD! *****\n");
		}
		#endregion 

		static void Main()
		{
			Console.WriteLine("***** The Amazing AppDomain app *****\n");
			
			// Get info for current AppDomain.
			AppDomain defaultAD = AppDomain.CurrentDomain;
			MessageBox.Show("Hello");
			PrintAllAssembliesInAppDomain(defaultAD);

            // Make a new AppDomain in the current process. 
            AppDomain anotherAD = AppDomain.CreateDomain("SecondAppDomain");
            anotherAD.Load("CarLibrary");

            PrintAllAssembliesInAppDomain(anotherAD);

            // Hook into DomainUnload event.
            anotherAD.DomainUnload
                += new EventHandler(anotherAD_DomainUnload);
            defaultAD.ProcessExit
                += new EventHandler(defaultAD_ProcessExit);

            // Now unload anotherAD.
            AppDomain.Unload(anotherAD);

            Console.ReadLine(); // Unloads default app domain upon exit.
        }
	}
}

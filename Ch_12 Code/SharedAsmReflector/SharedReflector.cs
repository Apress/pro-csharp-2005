using System;
using System.Reflection;
using System.IO;

namespace SharedAsmReflector
{
	public class SharedAsmReflector
	{
		private static void DisplayInfo(Assembly a)
		{
			Console.WriteLine("***** Info about Assembly *****");
			Console.WriteLine("Loaded from GAC? {0}", a.GlobalAssemblyCache);
			Console.WriteLine("Asm Name: {0}", a.GetName().Name);
			Console.WriteLine("Asm Version: {0}", a.GetName().Version);
			Console.WriteLine("Asm Culture: {0}", a.GetName().CultureInfo.DisplayName);
			Type[] types = a.GetTypes();
			for(int i = 0; i < 20; i++)
				Console.WriteLine("Type: {0}", types[i]);
			Console.WriteLine("******************************\n");
		}
 
		static void Main(string[] args)
		{
			Console.WriteLine("***** The Shared Asm Reflector App *****\n");
	
			// Load System.Windows.Forms.dll from GAC.
			string displayName = null;
			displayName = "System.Windows.Forms," +
                "Version=2.0.0.0," +
                "PublicKeyToken=b77a5c561934e089," +
                @"Culture=""";
			Assembly asm = Assembly.Load(displayName);
            DisplayInfo(asm);
            Console.ReadLine();
        }
	}
}

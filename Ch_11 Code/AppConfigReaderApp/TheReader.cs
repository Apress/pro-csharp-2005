using System;

// For programmatic access to .NET *.config files. 
using System.Configuration;

namespace AppConfigReaderApp
{
	class Program
	{
		static void Main(string[] args)
		{
			AppSettingsReader ar = 
				new AppSettingsReader();
			Console.WriteLine("***** Here is your conn string *****");
			Console.WriteLine(ar.GetValue("appConStr", 
				typeof(string)));
			Console.WriteLine();
			int numbOfTimes = (int)ar.GetValue("timesToSayHello", 
				typeof(int));
			for(int i = 0; i < numbOfTimes; i++)
				Console.WriteLine("Yo!");
            Console.ReadLine();
        }
	}
}









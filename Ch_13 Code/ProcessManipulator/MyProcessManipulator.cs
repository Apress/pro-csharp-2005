using System;
using System.Diagnostics;

namespace ProcessManipulator
{
	class MyProcessManipulator
	{
		#region List all procs f(x)
		public static void ListAllRunningProcesses()
		{
			// Get all processes on local machine.
			Process[] runningProcs = Process.GetProcesses(".");
			foreach(Process p in runningProcs)
			{
				string info = string.Format("-> PID: {0}\tName: {1}",
					p.Id, p.ProcessName);				
				Console.WriteLine(info);
			}
			Console.WriteLine("************************************\n");
		}
		#endregion

		#region Enum threads in proc f(x)
		public static void EnumThreadsForPid(int pID)
		{
			Process theProc;

			try
			{
				theProc = Process.GetProcessById(pID);
			}
			catch
			{
				Console.WriteLine("-> Sorry...bad PID!");
				Console.WriteLine("************************************\n");
				return;
			}

            Console.WriteLine("Here are the threads used by: {0}",
                theProc.ProcessName);

			ProcessThreadCollection theThreads = theProc.Threads;
			foreach(ProcessThread pt in theThreads)
			{
				string info = string.Format("-> Thread ID: {0}\tStart Time {1}\tPriority {2}",
				pt.Id , pt.StartTime.ToShortTimeString(), pt.PriorityLevel);
				Console.WriteLine(info);
			}
			Console.WriteLine("************************************\n");
		}
		#endregion 

		#region Enum mods in proc f(x)
		public static void EnumModsForPid(int pID)
		{
			Process theProc;

			try
			{theProc = Process.GetProcessById(pID);}
			catch
			{
				Console.WriteLine("-> Sorry...bad PID!");
				Console.WriteLine("************************************\n");
				return;
			}
			
			Console.WriteLine("Here are the loaded modules for: {0}", 
				theProc.ProcessName);
			try
			{
				ProcessModuleCollection theMods = theProc.Modules;
				foreach(ProcessModule pm in theMods)
				{
					string info = 
						string.Format("-> Mod Name: {0}", pm.ModuleName);
					Console.WriteLine(info);
				}
				Console.WriteLine("************************************\n");
			}
			catch{Console.WriteLine("No mods!");}
		}
		#endregion

		#region Start / Kill proc f(x)
		public static void StartAndKillProcess()
		{
			Console.Write("--> Hit a key to launch IE");
			Console.ReadLine();

			// Launch IE.
			Process ieProc = Process.Start("IExplore.exe",
                "www.intertechtraining.com");

            Console.Write("--> Hit a key to kill {0}...", ieProc.ProcessName);
			Console.ReadLine();

			// Kill the process.
			try
			{
				ieProc.Kill();
			}
			catch{} // In case user already killed it...
		}
		#endregion 

		static void Main(string[] args)
		{
			Console.WriteLine("***** The Amazing Process Manipulator App *****\n");

			// Get list of all processes running on local machine.
			Console.WriteLine("***** Listing all running processes *****");
			ListAllRunningProcesses();

            // Enumerate over threads / mods in a given PID.
            Console.WriteLine("***** Enter PID of process to investigate *****");
            Console.Write("PID: ");
            string pID = Console.ReadLine();

            try
            {
                int theProcID = int.Parse(pID);
                EnumThreadsForPid(theProcID);
                EnumModsForPid(theProcID);

                // Launch / kill a process.
                StartAndKillProcess();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
	}
}

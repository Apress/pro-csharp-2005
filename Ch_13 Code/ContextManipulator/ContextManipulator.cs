using System;
using System.Runtime.Remoting.Contexts;
using System.Threading;

namespace ContextManipulator
{
	#region Example class types
	// SportsCar has no special contextual
	// needs, and will thus be loaded into the 
	// default context of the app domain.
	public class SportsCar
	{
		public SportsCar()
		{
			Context ctx = Thread.CurrentContext;
			Console.WriteLine("{0} object in context {1}", 
				this.ToString(), ctx.ContextID);
			foreach(IContextProperty itfCtxProp in ctx.ContextProperties)
				Console.WriteLine("-> Ctx Prop: {0}", itfCtxProp.Name);
		}
	}

	// SportsCarTS demands to be loaded in 
	// a synchronization context.
	[Synchronization]
	public class SportsCarTS : ContextBoundObject
	{
		public SportsCarTS()
		{
			Context ctx = Thread.CurrentContext;
            Console.WriteLine("{0} object in context {1}",
                this.ToString(), ctx.ContextID);
            foreach (IContextProperty itfCtxProp in ctx.ContextProperties)
                Console.WriteLine("-> Ctx Prop: {0}", itfCtxProp.Name);
		}
	}
	#endregion

	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("***** The Amazing Context Application *****\n");

            // Objects will display contextual info upon creation.			
            SportsCar sport = new SportsCar();
            Console.WriteLine();

            SportsCar sport2 = new SportsCar();
            Console.WriteLine();

            SportsCarTS synchroSport = new SportsCarTS();
            Console.ReadLine();
        }
	}
}
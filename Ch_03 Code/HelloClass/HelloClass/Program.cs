using System;

/* Note!  I have set some command line
 * parameters using the Properties 
 * dialog.  */
namespace HelloThereExample
{
    #region The Hello Class
    class HelloClass
    {
        // Constructors always assign state data to default values. 
        public HelloClass()
        { Console.WriteLine("Default ctor called!"); }

        // This custom constructor assigns state data to a known value.
        public HelloClass(string msg)
        {
            Console.WriteLine("Custom ctor called!");
            userMessage = msg;
        }

        // A point of state data.
        public string userMessage;

        public void PrintMessage()
        {
            Console.WriteLine("Message is: {0}", userMessage);
        }
    }
    #endregion

    class HelloApp
    {
        // Program entry point.
        public static int Main(string[] args)
        {
            #region Process Command Line Args...
            // Process command line arguments...
            Console.WriteLine("***** Command line args *****");
            for (int x = 0; x < args.Length; x++)
            {
                Console.WriteLine("Arg: {0}", args[x]);
            }

            // One more time using foreach!
            Console.WriteLine("\n***** Just in case you missed it *****");
            foreach (string s in args)
                Console.WriteLine("Arg: {0}", s);

            // Now using System.Environment
            Console.WriteLine("\n***** Using System.Environment *****");
            string[] theArgs = Environment.GetCommandLineArgs();
            Console.WriteLine("Path to this app is: {0}", theArgs[0]);

            for (int i = 1; i < theArgs.Length; i++)
                Console.WriteLine("Again, the args is: {0}", theArgs[i]);
            Console.WriteLine();
            #endregion

            #region Use System.Environment type
            // OS?
            Console.WriteLine("Current OS: {0} ", Environment.OSVersion);

            // Directory?
            Console.WriteLine("Current Directory: {0} ",
                Environment.CurrentDirectory);

            // Here are the drives on this box.
            string[] drives = Environment.GetLogicalDrives();
            for (int i = 0; i < drives.Length; i++)
                Console.WriteLine("Drive {0} : {1} ", i, drives[i]);

            // Which version of the .NET platform is running this app?
            Console.WriteLine("Executing version of .NET: {0} ",
                Environment.Version);
            Console.WriteLine();
            #endregion

            // Call default constructor. 
            HelloClass c1 = new HelloClass();
            c1.PrintMessage();

            // Call parameterized constructor.
            HelloClass c2;
            c2 = new HelloClass("Testing, 1, 2, 3");
            c2.PrintMessage();
            Console.ReadLine();
            return 0;
        }
    }
}
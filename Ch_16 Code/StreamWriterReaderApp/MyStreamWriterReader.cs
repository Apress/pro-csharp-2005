using System;
using System.IO;

namespace StreamWriterReaderApp
{
    public class MyStreamWriterReader
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with StreamWriter / StreamReader *****\n");

			// Get a StreamWriter and write string data.
            // StreamWriter writer = File.CreateText("Thoughts.txt");
            StreamWriter writer = new StreamWriter("reminders.txt");
			writer.WriteLine("Don't forget Mother's Day this year...");
			writer.WriteLine("Don't forget Father's Day this year...");
			writer.WriteLine("Don't forget these numbers:");			
			for(int i = 0; i < 10; i++)
				writer.Write(i + " ");

            // Insert a new line.
            writer.Write(writer.NewLine);

			// Closing automatically flushes!
			writer.Close();
			Console.WriteLine("Created file and wrote some thoughts...");

			// Now read data from file.
			Console.WriteLine("Here are your thoughts:\n");
			// StreamReader sr = File.OpenText("reminders.txt");
            StreamReader sr = new StreamReader("reminders.txt");

			string input = null;
			while ((input = sr.ReadLine()) != null)
			{
				Console.WriteLine (input);
			}
        }
    }
}

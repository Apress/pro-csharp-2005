using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BinaryWriterReaderApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with BinaryWriter / BinaryReader *****\n");

            // Open a binary writer for a file.
            FileInfo f = new FileInfo("BinFile.dat");
            BinaryWriter bw = new BinaryWriter(f.OpenWrite());

            // Print out the type of BaseStream.
            // (System.IO.FileStream in this case).
            Console.WriteLine("Base stream is: {0}", bw.BaseStream);

            // Create some data to save in the file
            double aDouble = 1234.67;
            int anInt = 34567;
            char[] aCharArray = { 'A', 'B', 'C' };

            // Write the data
            bw.Write(aDouble);
            bw.Write(anInt);
            bw.Write(aCharArray);
            bw.Close();

            // Read the data as raw bytes
            BinaryReader br = new BinaryReader(f.OpenRead());
            int temp = 0;
            while (br.PeekChar() != -1)
            {
                // 
                Console.Write("{0,7:x} ", br.ReadByte());
                if (++temp == 4)
                {
                    // Write a new line every 4 bytes
                    Console.WriteLine();
                    temp = 0;
                }
            }
            Console.WriteLine();
        }
    }
}
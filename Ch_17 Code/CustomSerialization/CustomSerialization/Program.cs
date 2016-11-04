using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

// Don't forget to reference System.Runtime.Serialization.Formatters.Soap.dll.
using System.Runtime.Serialization.Formatters.Soap;

namespace CustomSerialization
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Custom Serialization *****\n");

            #region Serialize MyStringData
            // Persist MyStringData in SOAP format. 
            MyStringData sd = new MyStringData();
            sd.dataItemOne = "This is some data.";
            sd.dataItemTwo = "Here is some more data";

            Stream s = new FileStream("MyData.soap",
            FileMode.Create, FileAccess.Write, FileShare.None);

            SoapFormatter sf = new SoapFormatter();
            sf.Serialize(s, sd);
            s.Close();

            s = File.OpenRead("MyData.soap");
            sd = (MyStringData)sf.Deserialize(s);
            Console.WriteLine("Item 1: {0}", sd.dataItemOne); 

            Console.WriteLine("Item 2: {0}", sd.dataItemTwo);
            #endregion

            #region Serialize MoreData
            // Persist MoreData in SOAP format. 
            MoreData md = new MoreData();
            md.dataItemOne = "Testing 1, 2, 3.";
            md.dataItemTwo = "One more test...";

            s = new FileStream("MoreData.soap",
                FileMode.Create, FileAccess.Write, FileShare.None);

            sf = new SoapFormatter();
            sf.Serialize(s, md);
            s.Close();

            s = File.OpenRead("MoreData.soap");
            md = (MoreData)sf.Deserialize(s);
            Console.WriteLine("Item 1: {0}", md.dataItemOne);
            Console.WriteLine("Item 2: {0}", md.dataItemTwo);
            Console.ReadLine(); 
            #endregion
        }
    }
}

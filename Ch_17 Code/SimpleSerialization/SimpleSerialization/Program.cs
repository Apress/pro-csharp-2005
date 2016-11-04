using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

// The binary formatter is in mscorlib.dll
using System.Runtime.Serialization.Formatters.Binary;

// Must reference System.Runtime.Serialization.Formatters.Soap.dll!
using System.Runtime.Serialization.Formatters.Soap;

// XML formatter is also in mscorlib.dll.
using System.Xml.Serialization;

using System.Collections;

namespace SimpleSerialization
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Object Serialization *****\n");

            // Make a JamesBondCar and set state.
            JamesBondCar jbc = new JamesBondCar();
            jbc.canFly = true;
            jbc.canSubmerge = false;
            jbc.theRadio.stationPresets = new double[]{89.3, 105.1, 97.1};
            jbc.theRadio.hasTweeters = true;

            #region BinaryFormatter Logic
            // Save object to a file named CarData.dat in binary.
            BinaryFormatter binFormat = new BinaryFormatter();
            Stream fStream = new FileStream("CarData.dat",
                 FileMode.Create, FileAccess.Write, FileShare.None);
            binFormat.Serialize(fStream, jbc);
            fStream.Close();
            Console.WriteLine("-> Saved JamesBondCar in binary format.");

            // Read the JamesBondCar from the binary stream.
            fStream = File.OpenRead("CarData.dat");
            JamesBondCar carFromDisk =
                 (JamesBondCar)binFormat.Deserialize(fStream);
            Console.WriteLine("Can this car fly? : {0}", carFromDisk.canFly);
            fStream.Close(); 
            #endregion

            #region SoapFormatter Logic
            // Save object to a file named CarData.soap in SOAP format.
            SoapFormatter soapForamt = new SoapFormatter();
            fStream = new FileStream("CarData.soap",
                 FileMode.Create, FileAccess.Write, FileShare.None);
            soapForamt.Serialize(fStream, jbc);
            fStream.Close();
            Console.WriteLine("-> Saved JamesBondCar in SOAP format."); 
            #endregion

            #region XmlSeralizer Logic
            // Save object to a file named CarData.xml in XML format.
            XmlSerializer xmlForamt = new XmlSerializer(typeof(JamesBondCar),
                new Type[] { typeof(Radio), typeof(Car) });

            fStream = new FileStream("CarData.xml",
                 FileMode.Create, FileAccess.Write, FileShare.None);
            xmlForamt.Serialize(fStream, jbc);
            fStream.Close();
            Console.WriteLine("-> Saved JamesBondCar in XML format."); 
            #endregion

            #region Persist an ArrayList of serializable objects
            // Now persiste an ArrayList of JamesBondCars.
            ArrayList myCars = new ArrayList();
            myCars.Add(new JamesBondCar(true, true));
            myCars.Add(new JamesBondCar(true, false));
            myCars.Add(new JamesBondCar(false, true));
            myCars.Add(new JamesBondCar(false, false));

            fStream = new FileStream("CarCollection.xml",
                 FileMode.Create, FileAccess.Write, FileShare.None);

            xmlForamt = new XmlSerializer(typeof(ArrayList),
                new Type[] { typeof(JamesBondCar), typeof(Car), typeof(Radio) });
            xmlForamt.Serialize(fStream, myCars);
            fStream.Close();
            Console.WriteLine("-> Saved ArrayList of JamesBondCar in XML format.\n");  
            #endregion

            Console.ReadLine();
        }
    }
}
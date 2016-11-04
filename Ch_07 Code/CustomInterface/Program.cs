#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace CustomInterface
{
    class Program
    {
        #region Static helper methods
        // I'll draw anyone supporting IDraw3D!
        public static void DrawIn3D(IDraw3D itf3d)
        {
            Console.WriteLine("-> Drawing IDraw3D compatible type");
            itf3d.Draw();
        }

        static IPointy ExtractPointyness(object o)
        {
            if (o is IPointy)
                return (IPointy)o;
            else
                return null;
        } 
        #endregion

        static void Main(string[] args)
        {
			Console.WriteLine("***** Fun with interfaces *****");

            #region Obtaining interface references
//            // Cast for the interface reference.
//            Hexagon hex = new Hexagon("Bill");
//            Console.WriteLine("Points: {0}", ((IPointy)hex).Points);
//
//            // Safely cast for interface reference.
//            Circle c = new Circle("Lisa");
//            IPointy itfPt;
//            try
//            {
//                itfPt = (IPointy)c;
//                Console.WriteLine(itfPt.Points);
//            }
//            catch (InvalidCastException e)
//            { Console.WriteLine(e.Message); }
//
//            // Second way to test for an interface:
//            Hexagon hex2 = new Hexagon("Peter");
//            IPointy itfPt2;
//            itfPt2 = hex2 as IPointy;
//            if (itfPt2 != null)
//                Console.WriteLine("Points: {0}", itfPt2.Points);
//            else
//                Console.WriteLine("OOPS! Not pointy...");
//
//            // Third way to test for an interface.
//            Triangle t = new Triangle();
//            if (t is IPointy)
//                Console.WriteLine("Points: {0}", t.Points);
//            else
//                Console.WriteLine("OOPS! Not pointy..."); 
            #endregion

            Shape[] s = { new Hexagon(), new Circle(), new Triangle("Joe"),
              new Circle("JoJo")};
            for (int i = 0; i < s.Length; i++)
            {
                // Recall the Shape base class defines an abstract Draw() member,
                // so all shapes know how to draw themselves.
                s[i].Draw();

                // Who's pointy?
                if (s[i] is IPointy)
                    Console.WriteLine("-> Points: {0} ", ((IPointy)s[i]).Points);
                else
                    Console.WriteLine("-> {0}\'s not pointy!", s[i].PetName);

                // Can I draw you in 3D?
                if (s[i] is IDraw3D)
                    DrawIn3D((IDraw3D)s[i]);
            }

            #region Interfaces as return values
            // Attempt to get IPointy.
            Circle c = new Circle();
            IPointy itfPt = ExtractPointyness(c);
            if (itfPt != null)
                Console.WriteLine("Object has {0} points.", itfPt.Points);
            #endregion

            #region Print all the members in IPointy array
            Console.WriteLine("\n***** Printing out members in IPointy array *****");
            IPointy[] myPointyObjects = new IPointy[] {new Hexagon(), new Knife(),
                new Triangle(), new Fork(), new PitchFork()};

            for (int i = 0; i < myPointyObjects.Length; i++)
                Console.WriteLine("Object has {0} points.", myPointyObjects[i].Points); 
            #endregion

            Console.ReadLine();
        }
    }
}

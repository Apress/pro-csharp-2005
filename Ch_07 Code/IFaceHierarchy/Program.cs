#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace IFaceHierarchy
{
    #region SuperImage Class
    // This class supports IDrawable, IPrintable and IMetaFileRender.
    public class SuperImage : IMetaFileRender
    {
        public void Draw()
        {
            Console.WriteLine("Basic drawing logic.");
        }

		public void Print()
		{
            Console.WriteLine("Draw to printer.");
        }

		public void Render()
		{
            Console.WriteLine("Render to metafile.");
        }
    } 
    #endregion

    #region JamesBondCar
    public class JamesBondCar : IJamesBondCar
    {
        public void Drive() { Console.WriteLine("Speeding up..."); }
		public void Dive() { Console.WriteLine("Submerging..."); }
		public void TurboBoost() { Console.WriteLine("Blast off!"); }
	}
    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Interface Inheritance *****");
            Console.WriteLine("\n-> Using SuperImage");
            SuperImage si = new SuperImage();

            // Get IDrawable.
            IDrawable itfDraw = (IDrawable)si;
            itfDraw.Draw();

            // Now get IMetaFileRender which exposes all methods up
            // the chain of inheritance.
            if (itfDraw is IMetaFileRender)
            {
                IMetaFileRender itfMF = (IMetaFileRender)itfDraw;
                itfMF.Render();
                itfMF.Print();
            }

            Console.WriteLine("\n-> Using JamesBondCar");
            JamesBondCar j = new JamesBondCar();
			j.Drive();
			j.TurboBoost();
			j.Dive();
			

            Console.ReadLine();
        }
    }
}

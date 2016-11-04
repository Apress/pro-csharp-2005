#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace CustomInterface
{
    public abstract class Shape
    {
        // Shapes can be assigned a friendly pet name.
        protected string petName;

        // Constructors.
        public Shape() { petName = "NoName"; }
        public Shape(string s) { petName = s; }

        // Draw() is now completely abstract (note semicolon).
        public abstract void Draw();

        public string PetName
        {
            get { return petName; }
            set { petName = value; }
        }
    }
    
    // A given class may implement as many interfaces as necessary,
    // but may have exactly 1 base class.
    public class Hexagon : Shape, IPointy, IDraw3D
    {
        public Hexagon() { }
        public Hexagon(string name) : base(name) { }
        public override void Draw()
        {
            // Recall the Shape class defined the PetName property.
            Console.WriteLine("Drawing {0} the Hexagon", PetName);
        }

        #region IPointy Members
        public byte Points
        {
            get { return 6; }
        }
        #endregion

        #region IDraw3D Members

        void IDraw3D.Draw()
        {
            { Console.WriteLine("Drawing Hexagon in 3D!"); }
        }

        #endregion
    }

    public class Triangle : Shape, IPointy
    {
        public Triangle() { }
        public Triangle(string name) : base(name) { }
        public override void Draw()
        { Console.WriteLine("Drawing {0} the Triangle", PetName); }

        #region IPointy Members
        public byte Points
        {
            get {return 3;}
        }
        #endregion
    }

    public class Circle : Shape, IDraw3D
    {
        public Circle() { }
        public Circle(string name): base(name) { }

        // Now Circle must decide how to render itself.
        public override void Draw()
        {
            Console.WriteLine("Drawing {0} the Circle", PetName);
        }

        #region IDraw3D Members

        public void Draw3D()
        {
            { Console.WriteLine("Drawing Circle in 3D!"); }
        }

        #endregion
    }
    
    // Using explicit method implementation we are able
    // to provide distinct Draw() implementations.
    public class Line : Shape, IDraw3D
    {
        // You can only call this method using an IDraw3D interface reference.
        void IDraw3D.Draw()
        { Console.WriteLine("Drawing a 3D line..."); }

        // You can only call this using a Line (or base class) reference.
        public override void Draw()
        { Console.WriteLine("Drawing a line..."); }
    }

    #region Extra classes for examples
    // Not deriving from Shape, but still injecting a name clash.
    public class SuperImage : IDraw, IDrawToPrinter, IDraw3D
    {
        void IDraw.Draw()
        {  /* Basic drawing logic. */ }
        void IDrawToPrinter.Draw()
        {  /* Printer logic. */}
        void IDraw3D.Draw()
        {  /* 3D support. */}
    }

    class Knife : IPointy
    {
        #region IPointy Members
        byte IPointy.Points
        {
            get { return 1; }
        }
        #endregion
    }

    class Fork : IPointy
    {
        #region IPointy Members
        byte IPointy.Points
        {
            get { return 4; }
        }
        #endregion
    }

    class PitchFork : IPointy
    {
        #region IPointy Members
        byte IPointy.Points
        {
            get { return 3; }
        }
        #endregion

    } 
    #endregion

}

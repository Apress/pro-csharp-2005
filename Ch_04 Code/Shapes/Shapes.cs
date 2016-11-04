#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace Shapes
{
    #region Shape class
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
    #endregion

    #region Circle class
    public class Circle : Shape
    {
        public Circle() { }
        public Circle(string name): base(name) { }

        // Now Circle must decide how to render itself.
        public override void Draw()
        {
            Console.WriteLine("Drawing {0} the Circle", PetName);
        }
    }
    #endregion

    #region Hexagon class
    public class Hexagon : Shape
    {
        public Hexagon() { }
        public Hexagon(string name): base(name) { }
        public override void Draw()
        {
            Console.WriteLine("Drawing {0} the Hexagon", petName);
        }
    }
    #endregion

    public class ThreeDCircle : Circle
    {
        new protected string petName;
        new public void Draw()
        {
            Console.WriteLine("Drawing a 3D Circle");
        }
    }
}


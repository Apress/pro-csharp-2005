#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace CustomInterface
{
    // The pointy behavior as a read / write property.
    public interface IPointy
    {
        // Remove 'get' or 'set' to build read/write only property.
        byte Points { get;}
    }

    // The 3D drawing behavior.
    public interface IDraw3D
    {
        void Draw();
    }

    // Three interfaces each defining identical methods.
    public interface IDraw
    { 
        void Draw(); 
    }

    public interface IDrawToPrinter
    {
        void Draw(); 
    }
}

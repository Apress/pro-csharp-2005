#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace MemberAccess
{
    // Visibility options.
    class SomeClass
    {
        // Accessible anywhere.
        public void PublicMethod() { }

        // Accessible only from SomeClass types.
        private void PrivateMethod() { }

        // Accessible from SomeClass and any descendent.
        protected void ProtectedMethod() { }

        // Accessible from within the same assembly.
        internal void InternalMethod() { }

        // Assembly-protected access.
        protected internal void ProtectedInternalMethod() { }

        // Unmarked members are private by default in C#.
        void SomeMethod() { }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This app does nothing...but read the code comments;-)");
            // Make an object and attempt to call members.
            SomeClass c = new SomeClass();
            c.PublicMethod();
            c.InternalMethod();
            c.ProtectedInternalMethod();
//            c.PrivateMethod();      // Error!
//            c.ProtectedMethod();    // Error!
//            c.SomeMethod();         // Error!
            Console.ReadLine();
        }
    }
}

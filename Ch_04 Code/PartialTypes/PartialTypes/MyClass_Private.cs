using System;
using System.Collections.Generic;
using System.Text;

namespace PartialTypes
{
    // MyClass_Private.cs
    namespace PartialTypes
    {
        public partial class MyClass
        {
            // Private field data.
            private string someStringData;

            // All private helper members.
            public static void SomeStaticHelper() { }
        }
    }
}

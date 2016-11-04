using System;
using System.Collections.Generic;
using System.Text;

namespace PartialTypes
{
    // MyClass_Public.cs
    namespace PartialTypes
    {
        public partial class MyClass
        {
            // Constructors.
            public MyClass() { }

            // All public members.
            public void MemberA() { }
            public void MemberB() { }
        }
    }
}

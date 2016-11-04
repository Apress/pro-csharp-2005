#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

// Enforce CLS compliance for all public types in this assembly. 
[assembly: System.CLSCompliantAttribute(true)]

namespace AttributedCarLibrary
{
    #region My Custom Attribute
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, 
        AllowMultiple  = false, Inherited  = false)]
    public sealed class VehicleDescriptionAttribute : System.Attribute
    {
        private string msgData;

        public VehicleDescriptionAttribute(string description)
        { msgData = description; }
        public VehicleDescriptionAttribute() { }

        public string Description
        {
            get { return msgData; }
            set { msgData = value; }
        }
    }
    
    #endregion

    // This class is serializable 
    // and CLS compliant.
    [Serializable,
    VehicleDescription(Description = "My rocking Harley")]
    public class Motorcycle
    {
        // ...
    }

    [SerializableAttribute]
    [ObsoleteAttribute("This class is obsolete, use another vehicle!"),
    VehicleDescription("The old grey Mare she ain't what she used to be...")]
    public class HorseAndBuggy
    {
        // ...
    }

    [VehicleDescription("A very long, slow but feature rich auto")]
    public class Winnebago
    {
        //...
    }
}

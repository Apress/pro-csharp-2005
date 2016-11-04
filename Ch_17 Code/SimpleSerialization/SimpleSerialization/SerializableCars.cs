using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace SimpleSerialization
{
    [Serializable]
    public class Radio
    {
        // Made public for simplicity.
        public bool hasTweeters;
        public bool hasSubWoofers;
        public double[] stationPresets;

        [NonSerialized]
        public string radioID = "XF-552RR6";
    }

    [Serializable]
    public class Car
    {
        // Made public for simplicitly.
        public Radio theRadio = new Radio();
        public bool isHatchBack;
    }

[Serializable, XmlRoot(Namespace = "http://www.intertechtraining.com")]
public class JamesBondCar : Car
{
    public JamesBondCar(bool SkyWorthy, bool SeaWorthy)
    {
        canFly = SkyWorthy;
        canSubmerge = SeaWorthy;
    }
    public JamesBondCar(){}

    // Made public for simplicitly.
    [XmlAttribute]
    public bool canFly;
    [XmlAttribute]
    public bool canSubmerge;
}
}

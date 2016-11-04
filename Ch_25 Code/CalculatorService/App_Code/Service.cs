using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;

public struct Point
{
    public int x;
    public int y;
    public string pointName;
}

[WebService(Description = "The Amazing Calculator Web Service",
    Namespace ="http://www.IntertechTraining.com/",
    Name = "CalculatorWebService")]
[WebServiceBinding(ConformsTo = WsiProfiles.None , 
    EmitConformanceClaims = false)]
public class Service : System.Web.Services.WebService
{ 
    [WebMethod(Description = "Subtracts two integers.")]
    public int Subtract(int x, int y) { return x - y; }

    [WebMethod(Description = "Adds two float.", MessageName = "AddFloats")]
    public float Add(float x, float y) { return x + y; }

    [WebMethod(Description = "Adds two integers.", MessageName = "AddInts")]
    public int Add(int x, int y) { return x + y; }

    [WebMethod(Description = "Get the simple value of PI.")]
    public float GetSimplePI()
    { return (float)Application["SimplePI"]; }

    [WebMethod(EnableSession = true,
     Description = "Get your random number!")]
    public int GetMyRandomNumber()
    { return (int)Session["SessionRandomNumber"]; }

    [WebMethod( Description = "Get a Point.")]
    public Point GetMyPoint()
    {
        Point p = new Point();
        p.pointName = "MyPoint";
        p.x = 10;
        p.y = 40;
        return p;
    } 
}

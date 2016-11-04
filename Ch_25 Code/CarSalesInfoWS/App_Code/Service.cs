using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Serialization;

using System.Data;
using System.Data.SqlClient;

// A custom type.
public struct SalesInfoDetails
{
    public string info;
    [XmlAttribute]
    public DateTime dateExpired;
    public string Url;
}

[WebService(Namespace = "http://IntertechTraining.com/",
    Description = "A car-centric Web service", Name = "CarSalesInfoWS")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
public class Service : System.Web.Services.WebService
{
    [WebMethod(Description = "Get current discount blurbs")]
    public string[] GetSalesTagLines()
    {
        string[] currentDeals = {"Colt prices slashed 50%!",
               "All BMWs come with standard 8-track",
               "Free Pink Caravans...just ask me!"};
        return currentDeals;
    }

    [WebMethod(Description = "Sorts a list of car makes")]
    public string[] SortCarMakes(string[] theCarsToSort)
    {
        Array.Sort(theCarsToSort);
        return theCarsToSort;
    }

    [WebMethod(Description = "Get details of current sales")]
    public SalesInfoDetails[] GetSalesInfoDetails()
    {
        SalesInfoDetails[] theInfo = new SalesInfoDetails[3];
        theInfo[0].info = "Colt prices slashed 50%!";
        theInfo[0].dateExpired = DateTime.Parse("12/02/04");
        theInfo[0].Url = "http://www.CarsRUs.com";
        theInfo[1].info = "All BMWs come with standard 8-track";
        theInfo[1].dateExpired = DateTime.Parse("8/11/03");
        theInfo[1].Url = "http://www.Bmws4U.com";
        theInfo[2].info = "Free Pink Caravans...just ask me!";
        theInfo[2].dateExpired = DateTime.Parse("12/01/09");
        theInfo[2].Url = "http://www.AllPinkVans.com";
        return theInfo;
    }

    // Return all cars in inventory table.
    [WebMethod(Description =
      "Returns all autos in the Inventory table of the Cars database")]
    public DataSet GetCurrentInventory()
    {
        // Fill the DataSet with the Inventory table.
        SqlConnection sqlConn = new SqlConnection();
        sqlConn.ConnectionString = "data source=localhost; initial catalog=Cars;" +
             "uid=sa;pwd=";
        SqlDataAdapter myDA =
             new SqlDataAdapter("Select * from Inventory", sqlConn);
        DataSet ds = new DataSet();
        myDA.Fill(ds, "Inventory");
        return ds;
    } 
}

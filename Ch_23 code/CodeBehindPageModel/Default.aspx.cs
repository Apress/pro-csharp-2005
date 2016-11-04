using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnFillGrid_Click(object sender, EventArgs e)
    {
        // Emit a custom trace.
        Trace.Write("My Category", "Filling the grid!");

        SqlConnection sqlConn =
          new SqlConnection("Data Source=.;Initial Catalog=Cars;UID=sa;PWD=");
        sqlConn.Open();
        SqlCommand cmd =
          new SqlCommand("Select * From Inventory", sqlConn);
        carsGridView.DataSource = cmd.ExecuteReader();
        carsGridView.DataBind();
        sqlConn.Close();
    }
}
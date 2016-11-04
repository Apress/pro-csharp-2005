<%@ Page Language="C#" %>
<%@ Import Namespace = "System.Data.SqlClient" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.1//EN" "http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd">

<script runat="server">

    protected void btnFillData_Click(object sender, EventArgs e)
    {
        SqlConnection sqlConn =
            new SqlConnection("Data Source=.;Initial Catalog=Cars;UID=sa;PWD=");
        sqlConn.Open();
        SqlCommand cmd =
            new SqlCommand("Select * From Inventory", sqlConn);
        carsGridView.DataSource = cmd.ExecuteReader();
        carsGridView.DataBind();
        sqlConn.Close();
    }
</script>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Cars Inventory</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblInfo" runat="server" Text="Click on the Button to Fill the Grid">
        </asp:Label><br /><br />
        <asp:GridView ID="carsGridView" runat="server">
        </asp:GridView><br />
        <asp:Button ID="btnFillData" runat="server" Text="Fill Grid" OnClick="btnFillData_Click" />
    </div>
    </form>
</body>
</html>
<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Inventory.aspx.cs" Inherits="Default2" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label ID="Label1" runat="server" Font-Size="X-Large" Text="Here is what we currently have in stock!"></asp:Label>
    <br />
    <br />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="2"
        DataKeyNames="CarID" DataSourceID="CarsDataSource" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" AllowPaging="True" AllowSorting="True" ForeColor="Black" GridLines="None">
        <FooterStyle BackColor="Tan" />
        <Columns>
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
            <asp:BoundField DataField="CarID" HeaderText="CarID" ReadOnly="True" SortExpression="CarID" />
            <asp:BoundField DataField="Make" HeaderText="Make" SortExpression="Make" />
            <asp:BoundField DataField="Color" HeaderText="Color" SortExpression="Color" />
            <asp:BoundField DataField="PetName" HeaderText="PetName" SortExpression="PetName" />
        </Columns>
        <PagerStyle ForeColor="DarkSlateBlue" HorizontalAlign="Center" BackColor="PaleGoldenrod" />
        <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
        <HeaderStyle BackColor="Tan" Font-Bold="True" />
        <AlternatingRowStyle BackColor="PaleGoldenrod" />
    </asp:GridView>
    <asp:SqlDataSource ID="CarsDataSource" runat="server" ConnectionString="Data Source=localhost;Initial Catalog=Cars;Integrated Security=True"
        ProviderName="System.Data.SqlClient" SelectCommand="SELECT * FROM [Inventory]" DeleteCommand="DELETE FROM [Inventory] WHERE [CarID] = @original_CarID" InsertCommand="INSERT INTO [Inventory] ([CarID], [Make], [Color], [PetName]) VALUES (@CarID, @Make, @Color, @PetName)" UpdateCommand="UPDATE [Inventory] SET [Make] = @Make, [Color] = @Color, [PetName] = @PetName WHERE [CarID] = @original_CarID">
        <DeleteParameters>
            <asp:Parameter Name="original_CarID" Type="Int32" />
        </DeleteParameters>
        <UpdateParameters>
            <asp:Parameter Name="Make" Type="String" />
            <asp:Parameter Name="Color" Type="String" />
            <asp:Parameter Name="PetName" Type="String" />
            <asp:Parameter Name="original_CarID" Type="Int32" />
        </UpdateParameters>
        <InsertParameters>
            <asp:Parameter Name="CarID" Type="Int32" />
            <asp:Parameter Name="Make" Type="String" />
            <asp:Parameter Name="Color" Type="String" />
            <asp:Parameter Name="PetName" Type="String" />
        </InsertParameters>
    </asp:SqlDataSource>
</asp:Content>


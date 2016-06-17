<%@ Page Language="C#" AutoEventWireup="true" CodeFile="baja.aspx.cs" Inherits="baja" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <p>
            Nombre de usuario:
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Borrar" Width="56px" OnClick="Button1_Click" />
        </p>
        <p>
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        </p>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=GUILLERMO\SQLEXPRESS;Initial Catalog=base1;Integrated Security=True" DeleteCommand="delete from usuarios where nombre = @nombre" ProviderName="System.Data.SqlClient">
            <DeleteParameters>
                <asp:Parameter Name="nombre" />
            </DeleteParameters>
        </asp:SqlDataSource>
    </form>
</body>
</html>

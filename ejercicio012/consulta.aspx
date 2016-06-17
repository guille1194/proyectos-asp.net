<%@ Page Language="C#" AutoEventWireup="true" CodeFile="consulta.aspx.cs" Inherits="consulta" %>

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
            Ingrese el nombre de usuario:
            <asp:TextBox ID="TextBox1" runat="server" style="margin-bottom: 3px"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Buscar" OnClick="Button1_Click" />
        </p>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </p>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Default.aspx">Retornar</asp:HyperLink>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=GUILLERMO\SQLEXPRESS;Initial Catalog=base1;Integrated Security=True" ProviderName="System.Data.SqlClient" SelectCommand="select clave,mail from usuarios where nombre = @nombre">
            <SelectParameters>
                <asp:Parameter Name="nombre" />
            </SelectParameters>
        </asp:SqlDataSource>
    </form>
    <p>
        &nbsp;</p>
</body>
</html>

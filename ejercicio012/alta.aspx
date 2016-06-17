<%@ Page Language="C#" AutoEventWireup="true" CodeFile="alta.aspx.cs" Inherits="alta" %>

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
            Nombre:
            <asp:TextBox ID="TextBox1" runat="server" style="margin-bottom: 1px"></asp:TextBox>
        </p>
        <p>
            Clave:
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
        <p>
            Mail:
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Alta" Height="25px" OnClick="Button1_Click" Width="57px" />
        </p>
        <p>
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        </p>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=GUILLERMO\SQLEXPRESS;Initial Catalog=base1;Integrated Security=True" InsertCommand="INSERT INTO usuarios(nombre, clave, mail) VALUES (@nombre, @clave, @mail)" ProviderName="System.Data.SqlClient">
            <InsertParameters>
                <asp:Parameter DefaultValue="" Name="nombre" />
                <asp:Parameter Name="clave" />
                <asp:Parameter Name="mail" />
            </InsertParameters>
        </asp:SqlDataSource>
    </form>
</body>
</html>

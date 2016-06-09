<%@ Page Language="C#" AutoEventWireup="true" CodeFile="carga.aspx.cs" Inherits="carga" %>

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
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <p>
            Pais:
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
        <p>
            Comentarios</p>
        <p>
            <asp:TextBox ID="TextBox3" runat="server" Height="161px" TextMode="MultiLine" Width="396px"></asp:TextBox>
        </p>
        <asp:Button ID="Button1" runat="server" Text="Confirmar" OnClick="Button1_Click" />
        <br />
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        <p>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Default.aspx">Retornar</asp:HyperLink>
        </p>
    </form>
</body>
</html>

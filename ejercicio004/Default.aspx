<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

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
            Ingrese primer valor:<asp:TextBox ID="TextBox1" runat="server" Height="16px"></asp:TextBox>
        </p>
        <p>
            Ingrese segundo valor:
            <asp:TextBox ID="TextBox2" runat="server" Height="18px"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <asp:RadioButton ID="RadioButton1" runat="server" OnCheckedChanged="RadioButton1_CheckedChanged" Text="Sumar" />

        <asp:RadioButton ID="RadioButton2" runat="server" Text="Restar" />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Resultado" OnClick="Button1_Click" />

        <p>
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        </p>

    </form>
</body>
</html>

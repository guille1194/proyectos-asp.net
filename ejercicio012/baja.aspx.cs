using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class baja : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlDataSource1.DeleteParameters["nombre"].DefaultValue = TextBox1.Text;
        int cant;
        cant = SqlDataSource1.Delete();
        if (cant == 1)
            Label1.Text = "Se borró el usuario";
        else
            Label1.Text = "No existe dicho nombre";
    }
}
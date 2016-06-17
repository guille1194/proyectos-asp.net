using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class alta : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlDataSource1.InsertParameters["nombre"].DefaultValue = TextBox1.Text;
        SqlDataSource1.InsertParameters["clave"].DefaultValue = TextBox2.Text;
        SqlDataSource1.InsertParameters["mail"].DefaultValue = TextBox3.Text;
        SqlDataSource1.Insert();
        Label1.Text = "Se efectuó la carga";
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
    }
}
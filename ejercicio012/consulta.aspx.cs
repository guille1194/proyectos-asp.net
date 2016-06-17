using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class consulta : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlDataSource1.SelectParameters["nombre"].DefaultValue = TextBox1.Text;
        SqlDataSource1.DataSourceMode = SqlDataSourceMode.DataReader;
        SqlDataReader datos;
        datos = (SqlDataReader)SqlDataSource1.Select(DataSourceSelectArguments.Empty);
        if (datos.Read())
            Label1.Text = "Clave:" + datos["clave"] + "<br>Mail:" + datos["mail"];
        else
            Label1.Text = "No existe un usuario con dicho nombre";
    }
}
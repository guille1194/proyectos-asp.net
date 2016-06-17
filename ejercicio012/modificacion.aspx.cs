using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class modificacion : System.Web.UI.Page
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
        {
            TextBox2.Text = datos["clave"].ToString();
            TextBox3.Text = datos["mail"].ToString();
        }
        else
            Label1.Text = "No existe un usuario con dicho nombre";
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        SqlDataSource1.UpdateParameters["nombre"].DefaultValue = TextBox1.Text;
        SqlDataSource1.UpdateParameters["clave"].DefaultValue = TextBox2.Text;
        SqlDataSource1.UpdateParameters["mail"].DefaultValue = TextBox3.Text;
        int cant;
        cant = SqlDataSource1.Update();
        if (cant == 1)
            Label2.Text = "Se modificaron los datos";
        else
            Label2.Text = "No existe dicho codigo de usuario";
    }
}
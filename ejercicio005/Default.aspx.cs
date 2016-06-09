using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        int x1 = int.Parse(TextBox1.Text);
        int x2 = int.Parse(TextBox2.Text);
        Label1.Text = "";
        int resultado;
        if (CheckBox1.Checked)
        {
            resultado = x1 + x2;
            this.Label1.Text = "La suma de los dos valores es: " + resultado + "<br>";
        }
        if (CheckBox2.Checked)
        {
            resultado = x1 - x2;
            Label1.Text = Label1.Text + "La diferencia de los dos valores es: " + resultado;
        }
    }
}
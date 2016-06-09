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

    protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        int x1 = int.Parse(TextBox1.Text);
        int x2 = int.Parse(TextBox2.Text);
        Label1.Text = "";
        if (ListBox1.Items[0].Selected)
        {
            int suma = x1 + x2;
            Label1.Text = "La suma es: " + suma + "<br>";
        }
        if (ListBox1.Items[1].Selected)
        {
            int resta = x1 - x2;
            Label1.Text += "La diferencia: " + resta + "<br>";
        }
        if (ListBox1.Items[2].Selected)
        {
            int multi = x1 * x2;
            Label1.Text += "El producto: " + multi + "<br>";
        }
        if (ListBox1.Items[3].Selected)
        {
            int divi = x1 / x2;
            Label1.Text += "La division: " + divi + "<br>";
        }
    }
}
﻿using System;
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
        int suma = x1 + x2;
        Label1.Text = "La suma de los dos valores es: " + suma;
    }
}
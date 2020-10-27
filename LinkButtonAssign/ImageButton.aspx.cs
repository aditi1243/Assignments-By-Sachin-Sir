using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
public partial class buttons : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Button1.Text = "The Button is pressed!";
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("default.aspx");//move to the next link i.e default.aspx
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
       TextBox1.Text="Keep smiling always";
    }
}
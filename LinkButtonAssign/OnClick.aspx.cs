using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppCal
{
    public partial class LinkButton : System.Web.UI.Page
    {
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Label1.Text = "Welcome To Facebook";
            Label1.Text = "Welcome To IASBaba";
            Label1.Text = "Welcome To Courseera";
            Label1.Text = "Welcome To Udemy";
            Label1.Text = "Welcome To Insights";
        }
    }
}
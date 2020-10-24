using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Controls_____
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Label1_Click(object sender, EventArgs e)
        {
            colorid.Text = "";
            if (Radiobutton1.Checked)
                colorid.Text = "This is ASP.Net Webform" + Radiobutton1.Text;

            else
                colorid.Text = "This is ASP.Net Webform" + Radiobutton2.Text;
        }




        protected void Radiobutton1_CheckedChanged(object sender, EventArgs e)
        {

            Response.Write("This is ASP.Net Webform and it is in Red Color");

         }

        protected void Radiobutton2_CheckedChanged(object sender, EventArgs e)
        {
        
            Response.Write("This is ASP.Net Webform and it is in Blue Color");
        }

        protected void Radiobutton3_CheckedChanged(object sender, EventArgs e)
        {
            Response.Write("This is ASP.Net Webform and it is in Green Color");
        }

        protected void Radiobutton4_CheckedChanged(object sender, EventArgs e)
        {
            Response.Write("This is ASP.Net Webform and it is in Yellow Color");
        }

        protected void Radiobutton5_CheckedChanged(object sender, EventArgs e)
        {
            Response.Write("This is ASP.Net Webform and it is in ForestGreen");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           

        }
    }
}
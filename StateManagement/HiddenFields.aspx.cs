using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebStateMangement
{
    public partial class WebCount : System.Web.UI.Page
    {
        int count;
        int Count1;
        int Count2;
        int count3;
        int count4;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            count =Convert.ToInt32( HiddenField1.Value);
            count++;
            Response.Write("Number of clicks on Button :" + count);
            HiddenField1.Value = count.ToString();
           
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Count1 = Convert.ToInt32(HiddenField2.Value);
            Count1++;
            Response.Write("Number of clicks on Button :" + Count1);
            HiddenField2.Value = Count1.ToString();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Count2 = Convert.ToInt32(HiddenField3.Value);
            Count2++;
            Response.Write("Number of clicks on Button :" + Count2);
            HiddenField3.Value = Count2.ToString();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            click3 = Convert.ToInt32(HiddenField4.Value);
            click3++;
            Response.Write("Number of clicks on Button :" + click3);
            HiddenField4.Value = click3.ToString();
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            click4 = Convert.ToInt32(HiddenField5.Value);
            click4++;
            Response.Write("Number of clicks on Button :" + click4);
            HiddenField5.Value = click4.ToString();
        }
    }
}
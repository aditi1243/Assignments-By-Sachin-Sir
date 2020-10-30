using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace SignUp
{
    public partial class Reg100 : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {

        }

      
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Label1.Text = "Registered Successfully";
            SqlConnection Connect = new SqlConnection(ConfigurationManager.ConnectionStrings["Table1ConnectionString"].ConnectionString);
            Connect.Open();

               var InsertQuery = "insert into TableSignUp (Name,Email,Password,Gender,City) values (@N, @E,@P,@G,@C)";

            SqlCommand Cmd = new SqlCommand(InsertQuery,Connect);
           
            Cmd.Parameters.AddWithValue("@N",TextBox1.Text);
            Cmd.Parameters.AddWithValue("@E", TextBox2.Text);
            Cmd.Parameters.AddWithValue("@P", TextBox3.Text);
             if (RadioButton1.Checked)
             {
                 Cmd.Parameters.AddWithValue("@G", RadioButton1.Text);
             }
            else
            {
               Cmd.Parameters.AddWithValue("@G", RadioButton2.Text);
            }
            Cmd.Parameters.AddWithValue("@C", DropDownList1.SelectedItem.ToString());

            Cmd.ExecuteNonQuery();
            Connect.Close();
            Response.Redirect("Admin.aspx.cs");
           
         }

        protected void Button1_Click1(object sender, EventArgs e)
        {

        }
    }
}
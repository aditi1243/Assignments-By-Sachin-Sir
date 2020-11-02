using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DataBoundContrl
{
    public partial class Employee : System.Web.UI.Page
    {
        SqlConnection Connect = new SqlConnection(ConfigurationManager.ConnectionStrings["EmployeeTableConnectionString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                Bind();
            }
            
        }
        public void Bind()
        {
            Connect.Open();
            SqlCommand Cmd = new SqlCommand("select * from StudentTable", Connect);//Giving Queries
            
           
            SqlDataAdapter SDA = new SqlDataAdapter(Cmd);//Retriving the data by creating an Instance
            DataSet Ds = new DataSet();//Setting the data into single frame
            SDA.Fill(Ds, "StudentTable");//Record of StudentTable records are bound with server
            RP1.DataSource = Ds.Tables[0];//Appearance of StudentTable records in terms of Table view on Web UI(Browser)
            RP1.DataBind();//Binding the data with Repeater Control to display the data from Employee table record
            Connect.Close();
        }

}

       
           

    }
    

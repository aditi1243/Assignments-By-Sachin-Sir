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
    public partial class ListViewaspx : System.Web.UI.Page
    {
        SqlConnection Connect = new SqlConnection(ConfigurationManager.ConnectionStrings["EmployeeTableConnectionString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                fillViewList();
            }

        }
        public void fillViewList()
        {
            try
            {
                Connect.Open();
                SqlCommand Cmd = new SqlCommand("select * from Employeetable", Connect);

                SqlDataAdapter SDA = new SqlDataAdapter(Cmd);
                DataSet Ds = new DataSet();
                Connect.Open();
                SDA.Fill(Ds);
                fillViewList1.DataSource = Ds;
                ViewList1.DataBind();
            }
            finally
            {
                Connect.Close();
            }
        }
}
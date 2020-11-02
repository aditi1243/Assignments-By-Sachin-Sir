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
    public partial class DataList_____aspx : System.Web.UI.Page
    {
        SqlConnection Connect = new SqlConnection(ConfigurationManager.ConnectionStrings["EmployeeTableConnectionString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                fillDataList();
            }
        }

            public void fillDataList()
        {
            try
            {
                Connect.Open();
                SqlCommand Cmd = new SqlCommand("select * from Employeetable", Connect);

                SqlDataAdapter SDA = new SqlDataAdapter(Cmd);
                DataSet Ds = new DataSet();
                Connect.Open();
                SDA.Fill(Ds);
                DataList1.DataSource = Ds;
                DataList1.DataBind();
            }
            finally
            {
                Connect.Close();
            }
        }

        }
    }

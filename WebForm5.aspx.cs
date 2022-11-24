using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebApplication2
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        //string con = "Data Source=DESKTOP-E0RSH11;Initial Catalog=aa;Integrated Security=True";
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-E0RSH11;Initial Catalog=aa;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            // Response.Write(Session["Id"]);
            Label1.Text = Session["Id"].ToString();
        }

       
        protected void Button1_Click1(object sender, EventArgs e)
        {
            string cm = "select * from Table1 where Email = '" + Label1.Text + "'";
            SqlCommand cmd = new SqlCommand(cm, con);
            con.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            DetailsView1.DataSource = rd;
            DetailsView1.DataBind();
            con.Close();
        }
    }
}
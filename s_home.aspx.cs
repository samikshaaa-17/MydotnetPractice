using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;


namespace WebApplication2
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Response.Write(Session["Id"]);
          //  string s = Session["Id"].ToString();
          // Label1.Text = "Welcome "+ s;
            string mail = Request.QueryString["email"];
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-E0RSH11;Initial Catalog=aa;Integrated Security=True");
            string cm = "select Course from Table1 where Email='"+ mail +"'";
            SqlCommand cmd = new SqlCommand(cm, con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            

            //rdr.Read();
            if (rdr.Read())
            {
                Label1.Text = rdr["Course"].ToString();
            }
            //string a = rdr["Course"].ToString();
            // Response.Write(a);
            Session["Name"] = Label1.Text;
            con.Close();

        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace WebApplication2
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string email="";
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-E0RSH11;Initial Catalog=aa;Integrated Security=True");
            string cm = " select * from Table1 where Email=@email and Password =@password ";
           
            SqlCommand cmd = new SqlCommand(cm, con);
            cmd.Parameters.AddWithValue("@email", TextBox2.Text);
            cmd.Parameters.AddWithValue("@password", TextBox3.Text);

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable tt = new DataTable();
            sda.Fill(tt);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();

            if (tt.Rows.Count > 0)
            {
                Session["Id"] =TextBox2.Text;
               
                Response.Redirect("s_home.aspx?email=" + TextBox2.Text );
               // Response.Redirect("WebForm4.aspx");
            }
            else
            {
                Label1.Text = "Your username and password is incorrect";
                Label1.ForeColor = System.Drawing.Color.Red;
            }
          //  Response.Write(Session["Id"]);
        }
    }
}
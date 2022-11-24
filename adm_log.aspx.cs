using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
namespace WebApplication2
{
    public partial class adm_log : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           // string email = "";
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-E0RSH11;Initial Catalog=aa;Integrated Security=True");
            string cm = " select * from adm_Tb where Name=@name and Passward =@passward ";

            SqlCommand cmd = new SqlCommand(cm, con);
            cmd.Parameters.AddWithValue("@name", TextBox1.Text);
            cmd.Parameters.AddWithValue("@passward", TextBox2.Text);

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable tt = new DataTable();
            sda.Fill(tt);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();

            if (tt.Rows.Count > 0)
            {
                Session["Id"] = TextBox1.Text;

               Response.Redirect("AD_home.aspx?name=" + TextBox1.Text);
               //  Response.Redirect("ad_home.aspx");
            }
            else
            {
                Label1.Text = "Your username and password is incorrect";
                Label1.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
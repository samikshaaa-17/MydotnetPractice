using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Windows;

namespace WebApplication2
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-E0RSH11;Initial Catalog=aa;Integrated Security=True");
       

        
        protected void Page_Load(object sender, EventArgs e)
        {
            //query string
            string mail = Request.QueryString["email"];    
            Label1.Text = "welcome  " + mail;

           // display data
           string cm = "select  Id, Name, Email, Phone ,Course from Table1 where Email='" + mail +"'";
            SqlCommand cmd = new SqlCommand(cm, con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
           DetailsView1.DataSource = rdr;
            DetailsView1.DataBind();
            con.Close();
           Response.Write(Session["Id"]);
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //GRID VIEW CODE
           SqlCommand cmd = new SqlCommand("select Id, Name, Email, Phone ,Course from Table1 where Name like @name",con);
             cmd.Parameters.AddWithValue("@name",TextBox1.Text);
             con.Open();
             SqlDataReader rdr = cmd.ExecuteReader();
             GridView1.DataSource = rdr;
             GridView1.DataBind();
             con.Close();
             
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //LOGOUT CODE  
            Session["Id"] = null;
            Session.Clear();
            Response.Cookies.Clear();
            Response.Cache.SetNoStore();
            Response.CacheControl = "no-cache";
            Response.Redirect("login.aspx");
        }
    }
}
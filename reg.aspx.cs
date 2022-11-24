using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
       
        protected void Button1_Click(object sender, EventArgs e)
        {
          
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-E0RSH11;Initial Catalog=aa;Integrated Security=True");
          string cm = "insert into Table1 (Name,Email,Password,Phone,Course) values ('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + DropDownList1.SelectedItem + "')";

           //string cm = "insert into Table_1 (Name,Email,Password,Sal) values ('adc','adc@gmail.com','12347',30000)";
             SqlCommand cmd = new SqlCommand(cm, con);
            con.Open();
            cmd.ExecuteNonQuery();
            Response.Write("Your data Sucessfully saved");
            con.Close();
            

        }

       
    }
}
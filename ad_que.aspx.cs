using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;


namespace WebApplication2
{
    public partial class ad_que : System.Web.UI.Page
    {
        //  string cm = "";
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-E0RSH11;Initial Catalog=aa;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
           
                string cm = "select * from html_tb";
                SqlCommand cmd = new SqlCommand(cm, con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                GridView1.DataSource = rdr;
                GridView1.DataBind();
                con.Close();
           
                string cm1 = "select * from css_tb";
                SqlCommand cmd1 = new SqlCommand(cm1, con);
                con.Open();
                SqlDataReader rdr1 = cmd1.ExecuteReader();
                GridView2.DataSource = rdr1;
                GridView2.DataBind();
                con.Close();
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
            if (DropDownList1.SelectedValue == "HTML")
            {
                string cm = "insert into html_tb (Id,Question,Opt1,Opt2,Opt3,Opt4,Answer) values(@id,@que,@op1,@op2,@op3,@op4,@answer)";
               
                SqlCommand cmd = new SqlCommand(cm, con);
                cmd.Parameters.AddWithValue("@id", TextBox1.Text);
                cmd.Parameters.AddWithValue("@que", TextArea1.Value);
                cmd.Parameters.AddWithValue("@op1", TextArea2.Value);
                cmd.Parameters.AddWithValue("@op2", TextArea3.Value);
                cmd.Parameters.AddWithValue("@op3", TextArea4.Value);
                cmd.Parameters.AddWithValue("@op4", TextArea5.Value);
                cmd.Parameters.AddWithValue("@answer",TextArea6.Value);
                
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            if (DropDownList1.SelectedValue == "CSS")
            {
                string cm = "insert into css_tb (Id,Question,Opt1,Opt2,Opt3,Opt4,Answer) values('" + TextBox1.Text + "','" + TextArea1.Value + "','" + TextArea2.Value + "','" + TextArea3.Value + "','" + TextArea4.Value + "','" + TextArea5.Value + "','" + TextArea6.Value + "')";
                SqlCommand cmd = new SqlCommand(cm, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }


           
           
        }
    }
}
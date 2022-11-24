using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
//using System.Windows;

namespace WebApplication2
{
    public partial class s_test : System.Web.UI.Page
    {
        // string s = Session["Id"].TOString();
        protected void Page_Load(object sender, EventArgs e)
        {
            string s = Session["Name"].ToString();
            Label1.Text = s;
            // string mail = Request.QueryString["email"];

            if (!IsPostBack)
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-E0RSH11;Initial Catalog=aa;Integrated Security=True");
                /*    string cm = "select Course from Table1 where Email='" + s + "'";
                     SqlCommand cmd = new SqlCommand(cm, con);
                     con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();


                   rdr.Read();
                   if (rdr.Read())
                     {
                        Label1.Text = rdr["Course"].ToString();
                     }
                   string a = rdr["Course"].ToString();
                    Response.Write(a);
                     con.Close();*/

                // code for binding reapeter

                if (Label1.Text == "HTML")
                {
                    string cm1 = "select * from html_tb";
                    SqlCommand cmd1 = new SqlCommand(cm1, con);
                    con.Open();
                    SqlDataAdapter sdr = new SqlDataAdapter(cmd1);
                    DataTable tt = new DataTable();
                    sdr.Fill(tt);
                    Repeater1.DataSource = tt;
                    Repeater1.DataBind();
                    con.Close();

                }
                if (Label1.Text == "CSS")
                {
                    string cm1 = "select * from css_tb";
                    SqlCommand cmd1 = new SqlCommand(cm1, con);
                    con.Open();
                    SqlDataAdapter sdr = new SqlDataAdapter(cmd1);
                    DataTable tt = new DataTable();
                    sdr.Fill(tt);
                    Repeater1.DataSource = tt;
                    Repeater1.DataBind();
                    con.Close();
                }
                con.Close();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int marks = 0;
            foreach (RepeaterItem ri in Repeater1.Items)
            {
                RadioButton rb1 = (RadioButton)ri.FindControl("RadioButton1");
                Label lblcorrans = (Label)ri.FindControl("Label2");
                //   lblcorrans.Visible = true;
                if (rb1.Checked == true)
                {
                    if (rb1.Text.Equals(lblcorrans.Text))
                    {
                        Label lbluserans = (Label)ri.FindControl("Label3");
                        lbluserans.Text = "The selected answer is<b> " + rb1.Text.ToString() + " </b>";
                        lbluserans.ForeColor = System.Drawing.Color.Green;
                        marks++;
                    }
                    else
                    {
                        Label wronguserans = (Label)ri.FindControl("Label3");
                        wronguserans.Text = "The selected answer <b>" + rb1.Text.ToString() + " </b> is wrong";
                        wronguserans.ForeColor = System.Drawing.Color.Red;
                    }
                }
            }

            foreach (RepeaterItem ri in Repeater1.Items)
            {
                RadioButton rb2 = (RadioButton)ri.FindControl("RadioButton2");
                Label lblcorrans = (Label)ri.FindControl("Label2");
                //  lblcorrans.Visible = true;
                if (rb2.Checked == true)
                {
                    if (rb2.Text.Equals(lblcorrans.Text))
                    {
                        Label lbluserans = (Label)ri.FindControl("Label3");
                        lbluserans.Text = "The selected answer is<b> " + rb2.Text.ToString() + " </b>";
                        lbluserans.ForeColor = System.Drawing.Color.Green;
                        marks++;
                    }
                    else
                    {
                        Label wronguserans = (Label)ri.FindControl("Label3");
                        wronguserans.Text = "The selected answer <b> " + rb2.Text.ToString() + " </b>is wrong";
                        wronguserans.ForeColor = System.Drawing.Color.Red;
                    }
                }
            }

            foreach (RepeaterItem ri in Repeater1.Items)
            {
                RadioButton rb3 = (RadioButton)ri.FindControl("RadioButton3");
                Label lblcorrans = (Label)ri.FindControl("Label2");
                // lblcorrans.Visible = true;
                if (rb3.Checked == true)
                {
                    if (rb3.Text.Equals(lblcorrans.Text))
                    {
                        Label lbluserans = (Label)ri.FindControl("Label3");
                        lbluserans.Text = "The selected answer is <b>" + rb3.Text.ToString() + " </b>";
                        lbluserans.ForeColor = System.Drawing.Color.Green;
                        marks++;
                    }
                    else
                    {
                        Label wronguserans = (Label)ri.FindControl("Label3");
                        wronguserans.Text = "The selected answer<b> " + rb3.Text.ToString() + " </b>is wrong";
                        wronguserans.ForeColor = System.Drawing.Color.Red;
                    }
                }
            }

            foreach (RepeaterItem ri in Repeater1.Items)
            {
                RadioButton rb4 = (RadioButton)ri.FindControl("RadioButton4");
                Label lblcorrans = (Label)ri.FindControl("Label2");
                // lblcorrans.Visible = true;
                if (rb4.Checked == true)
                {
                    if (rb4.Text.Equals(lblcorrans.Text))
                    {
                        Label lbluserans = (Label)ri.FindControl("Label3");
                        lbluserans.Text = "The selected answer is <b> " + rb4.Text.ToString() + " </b>";
                        lbluserans.ForeColor = System.Drawing.Color.Green;
                        marks++;
                    }
                    else
                    {
                        Label wronguserans = (Label)ri.FindControl("Label3");
                        wronguserans.Text = "The selected answer<b> " + rb4.Text.ToString() + "</b>  is wrong";
                        wronguserans.ForeColor = System.Drawing.Color.Red;
                    }
                }
                Label4.Text = marks.ToString() + " / " + Repeater1.Items.Count;

            }
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Asp.net_Sign_Up
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit_Click(object sender, EventArgs e)
        {

            Response.Redirect("Home.aspx");

            //SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);

            //con.Open();
            //SqlCommand cmd = new SqlCommand("select * from login where uname = @username and passwd = @password", con);

            //cmd.Parameters.AddWithValue("@username", TextBox1.Text);
            //cmd.Parameters.AddWithValue("@password", TextBox2.Text);

            //SqlDataReader sdr = cmd.ExecuteReader();

            //if (sdr.Read())
            //{
            //    Response.Redirect("Home.aspx");

            //}
            //else
            //{
            //    Label1.Text = "Username or Password Incorrect...!";
            //}

            //con.Close();
        }
    }
}
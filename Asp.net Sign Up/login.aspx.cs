using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;

namespace Asp.net_Sign_Up
{
    public partial class login : System.Web.UI.Page
    {

        MySqlConnection con = new MySqlConnection("server=127.0.0.1;user id=root; pwd = root; database=proyecto_teoria"); //AQUI SE CAMBIA LA BASE DE DATOS
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit_Click(object sender, EventArgs e)
        {

            
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select * from usuarios where usuario = @username and clave = @userpass", con);

            cmd.Parameters.AddWithValue("@username", txtID.Text); //ID
            cmd.Parameters.AddWithValue("@userpass", txtName.Text); //Name 

            MySqlDataReader sdr = cmd.ExecuteReader();

            if (sdr.Read())
            {

                Session["username"] = txtID.Text.ToString();
                Session["userpass"] = txtName.Text.ToString();

                Response.Redirect("MainMenu.aspx");

            }
            else
            {
                Label1.Text = "Username or Password Incorrect...!";
            }

            con.Close();
        }
    }
}
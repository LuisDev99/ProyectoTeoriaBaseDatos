using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using MySql.Data.MySqlClient;

namespace Asp.net_Sign_Up
{
    public partial class ordenes_desarollo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            using (MySqlConnection con = new MySqlConnection("server=127.0.0.1;user id=root; pwd = root; database=proyecto_teoria"))
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * from actividades", con);
                MySqlDataReader dr = cmd.ExecuteReader();
                GridView1.DataSource = dr;
                GridView1.DataBind();
                con.Close();
            }

        }
    }
}
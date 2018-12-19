using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;

namespace Asp.net_Sign_Up
{
    public partial class solicitud_ordendesarollo : System.Web.UI.Page
    {
        MySqlConnection con = new MySqlConnection("server=127.0.0.1;user id=root; pwd = root; database=proyecto_teoria"); //AQUI SE CAMBIA LA BASE DE DATOS

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {

            String Cliente_ID = Session["username"].ToString();
            String Nombre = txtNombre.Text.ToString();
            String Tecnologia = txtTecnologia.Text.ToString();

            MySqlCommand insert = new MySqlCommand("Create_OrdenDes", con);
            insert.Parameters.Add(new MySqlParameter("P_ID_C", "CUS-1"));
            insert.Parameters.Add(new MySqlParameter("P_Nombre", Nombre));
            insert.Parameters.Add(new MySqlParameter("P_Tec", Tecnologia));

            insert.CommandType = CommandType.StoredProcedure;

            try
            {
                con.Open();
                insert.ExecuteNonQuery();
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Se guardo exitosamente')", true);
            }
            catch (Exception ex)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Ha ocurrido un error "+ ex.Message.ToString() + "')", true);
                
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }


        }

        protected void btnMenu_Click(object sender, EventArgs e)
        {
            Response.Redirect("MainMenu.aspx");
        }
    }
}
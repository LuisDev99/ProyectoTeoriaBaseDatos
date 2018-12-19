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
    public partial class aprobacion_ordendesarollo : System.Web.UI.Page
    {
        MySqlConnection con = new MySqlConnection("server=127.0.0.1;user id=root; pwd = root; database=proyecto_teoria"); //AQUI SE CAMBIA LA BASE DE DATOS
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                PopulateGridview();

            }
        }
        //LLENAR EL GRIDVIEW
        void PopulateGridview()
        {
            DataTable dtbl1 = new DataTable();
            MySqlDataAdapter show = new MySqlDataAdapter("select * from view_orden", con);
            show.Fill(dtbl1);

            if (dtbl1.Rows.Count > 0)
            {
                EquiposGV.DataSource = dtbl1;
                EquiposGV.DataBind();
            }
            else
            {
                dtbl1.Rows.Add(dtbl1.NewRow());
                EquiposGV.DataSource = dtbl1;
                EquiposGV.DataBind();
                EquiposGV.Rows[0].Cells.Clear();
                EquiposGV.Rows[0].Cells.Add(new TableCell());
                EquiposGV.Rows[0].Cells[0].Text = "No Data Found..!";
                EquiposGV.Rows[0].Cells[0].HorizontalAlign = HorizontalAlign.Center;

            }

        }

        //EVENT TRIGGERED WHEN ADD NEW BUTTON IS PRESSED
        protected void EquiposGV_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            
        }

        protected void EquiposGV_RowEditing(object sender, GridViewEditEventArgs e)
        {
            EquiposGV.EditIndex = e.NewEditIndex;
            PopulateGridview();
        }

        protected void EquiposGV_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            EquiposGV.EditIndex = -1;
            PopulateGridview();
        }

        protected void EquiposGV_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            String Codigo = (EquiposGV.Rows[e.RowIndex].FindControl("txtCodigo_de_orden") as TextBox).Text.Trim();
            String Cliente = (EquiposGV.Rows[e.RowIndex].FindControl("txtCliente") as TextBox).Text.Trim();
            String Nombre = (EquiposGV.Rows[e.RowIndex].FindControl("txtNombreproyecto") as TextBox).Text.Trim();

            String Tec = (EquiposGV.Rows[e.RowIndex].FindControl("txtTecnologia") as TextBox).Text.Trim();


            MySqlCommand update = new MySqlCommand("Update_OrdenDes", con);

            update.Parameters.Add(new MySqlParameter("P_ID_O", Codigo));
            update.Parameters.Add(new MySqlParameter("P_Nombre", Nombre));
            update.Parameters.Add(new MySqlParameter("P_Tec", Tec));
       

            update.CommandType = CommandType.StoredProcedure;
            try
            {
                con.Open();
                update.ExecuteNonQuery();
                EquiposGV.EditIndex = -1;
                PopulateGridview();
                lbSuccesMessage.Text = "Selected Row Updated";
                lblErrorMessage.Text = "";
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Se aprobo exitosamente')", true);
            }
            catch (Exception ex)
            {
                lbSuccesMessage.Text = "";
                lblErrorMessage.Text = ex.Message;
                throw;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }



            update = new MySqlCommand("Create_project", con);

            update.Parameters.Add(new MySqlParameter("P_ID_O", Codigo));
            update.Parameters.Add(new MySqlParameter("P_Nombre", Nombre));
            update.Parameters.Add(new MySqlParameter("P_U", Tec));
            update.Parameters.Add(new MySqlParameter("P_Tipo", "sdj"));
            update.Parameters.Add(new MySqlParameter("P_URLGIT", "skd"));
            update.Parameters.Add(new MySqlParameter("P_URLTRELLO", "git"));
            update.Parameters.Add(new MySqlParameter("P_FechaS", "2018-04-12"));
            update.Parameters.Add(new MySqlParameter("P_FechaI", "2018-04-12"));
            update.Parameters.Add(new MySqlParameter("P_FechaF", "2018-04-12"));
            update.Parameters.Add(new MySqlParameter("P_Estado", "On Track"));
            update.Parameters.Add(new MySqlParameter("P_ID_T", 1));


            update.CommandType = CommandType.StoredProcedure;

            try
            {
                con.Open();
                update.ExecuteNonQuery();
                EquiposGV.EditIndex = -1;
                PopulateGridview();
                lbSuccesMessage.Text = "Selected Row Updated";
                lblErrorMessage.Text = "";
            }
            catch (Exception ex)
            {
                lbSuccesMessage.Text = "";
                lblErrorMessage.Text = ex.Message;
                throw;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }




        }

        protected void EquiposGV_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            MySqlCommand delete = new MySqlCommand("Delete_orden", con);

            String Codigo = (EquiposGV.Rows[e.RowIndex].FindControl("txtCodigo_de_orden") as TextBox).Text.Trim();

            delete.Parameters.AddWithValue("P_orden", Codigo);
            delete.CommandType = CommandType.StoredProcedure;

            try
            {
                con.Open();
                delete.ExecuteNonQuery();
                EquiposGV.EditIndex = -1;
                PopulateGridview();
                lbSuccesMessage.Text = "Selected Row Deled";
                lblErrorMessage.Text = "";
            }
            catch (Exception ex)
            {
                lbSuccesMessage.Text = "";
                lblErrorMessage.Text = ex.Message;
                throw;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }
    }
}
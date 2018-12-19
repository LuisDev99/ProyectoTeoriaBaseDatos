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
    public partial class ingreso_herramientas : System.Web.UI.Page
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
            MySqlDataAdapter show = new MySqlDataAdapter("SELECT * FROM tools", con);
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
            if (e.CommandName.Equals("Add"))
            {

                String Codigo = (EquiposGV.FooterRow.FindControl("txtCodigo_de_herramientaFooter") as TextBox).Text.Trim();
                String Nombre = (EquiposGV.FooterRow.FindControl("txtNombreFooter") as TextBox).Text.Trim();
                String Tipo = (EquiposGV.FooterRow.FindControl("txtTipoFooter") as TextBox).Text.Trim();

                MySqlCommand insert = new MySqlCommand("Create_tools", con);

                insert.Parameters.Add(new MySqlParameter("P_N", Nombre));
                insert.Parameters.Add(new MySqlParameter("P_T", Tipo));

                insert.CommandType = CommandType.StoredProcedure;
                try
                {
                    con.Open();
                    insert.ExecuteNonQuery();
                    PopulateGridview();
                    lbSuccesMessage.Text = "New Record Added";
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
            String Codigo = (EquiposGV.Rows[e.RowIndex].FindControl("txtCodigo_de_herramienta") as TextBox).Text.Trim();
            String Nombre = (EquiposGV.Rows[e.RowIndex].FindControl("txtNombre") as TextBox).Text.Trim();
            String Tiempo = (EquiposGV.Rows[e.RowIndex].FindControl("txtTipo") as TextBox).Text.Trim();

            MySqlCommand update = new MySqlCommand("Update_tools", con);

            update.Parameters.Add(new MySqlParameter("P_id", Codigo));
            update.Parameters.Add(new MySqlParameter("P_N", Nombre));
            update.Parameters.Add(new MySqlParameter("P_T", Tiempo));

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
            MySqlCommand delete = new MySqlCommand("Delete_Teams", con);

            String Codigo = (EquiposGV.Rows[e.RowIndex].FindControl("txtCodigo_de_EquipoFooter") as TextBox).Text.Trim();

            delete.Parameters.AddWithValue("P_ID", Codigo);
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
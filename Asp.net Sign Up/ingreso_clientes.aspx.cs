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
    public partial class ingreso_clientes : System.Web.UI.Page
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
            MySqlDataAdapter show = new MySqlDataAdapter("SELECT * FROM clientes", con);
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

                
                String Nombre = (EquiposGV.FooterRow.FindControl("txtNombreFooter") as TextBox).Text.Trim();
                String Telefono = (EquiposGV.FooterRow.FindControl("txtTelefonoFooter") as TextBox).Text.Trim();
                String Pagina = (EquiposGV.FooterRow.FindControl("txtPaginaWebFooter") as TextBox).Text.Trim();
                String Correo = (EquiposGV.FooterRow.FindControl("txtCorreoElectronicoFooter") as TextBox).Text.Trim();
                String Pais = (EquiposGV.FooterRow.FindControl("txtPaisFooter") as TextBox).Text.Trim();
                String Calle = (EquiposGV.FooterRow.FindControl("txtCalleFooter") as TextBox).Text.Trim();
                String Avenida = (EquiposGV.FooterRow.FindControl("txtAvenidaFooter") as TextBox).Text.Trim();
                String Ciudad = (EquiposGV.FooterRow.FindControl("txtCiudadFooter") as TextBox).Text.Trim();
                String Zip = (EquiposGV.FooterRow.FindControl("txtZip_CodeFooter") as TextBox).Text.Trim();
                String Estado = (EquiposGV.FooterRow.FindControl("txtEstadoFooter") as TextBox).Text.Trim();
                String Referencia = (EquiposGV.FooterRow.FindControl("txtReferenciaFooter") as TextBox).Text.Trim();
                
                MySqlCommand insert = new MySqlCommand("Create_cliente", con);

                insert.Parameters.Add(new MySqlParameter("P_nombre", Nombre));
                insert.Parameters.Add(new MySqlParameter("P_Telefono", Telefono));
                insert.Parameters.Add(new MySqlParameter("P_pagina_web", Pagina));
                insert.Parameters.Add(new MySqlParameter("P_correo", Correo));
                insert.Parameters.Add(new MySqlParameter("P_pais", Pais));
                insert.Parameters.Add(new MySqlParameter("P_calle", Calle));
                insert.Parameters.Add(new MySqlParameter("P_avenida", Avenida));
                insert.Parameters.Add(new MySqlParameter("P_ciudad", Ciudad));
                insert.Parameters.Add(new MySqlParameter("P_zip", Zip));
                insert.Parameters.Add(new MySqlParameter("P_estado", Estado));
                insert.Parameters.Add(new MySqlParameter("P_referencia", Referencia));


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
            
            String Codigo = (EquiposGV.Rows[e.RowIndex].FindControl("txtCodigo_de_Cliente") as TextBox).Text.Trim();
            String Nombre = (EquiposGV.Rows[e.RowIndex].FindControl("txtNombre") as TextBox).Text.Trim();
            String Telefono = (EquiposGV.Rows[e.RowIndex].FindControl("txtTelefono") as TextBox).Text.Trim();
            String Pagina = (EquiposGV.Rows[e.RowIndex].FindControl("txtPaginaWeb") as TextBox).Text.Trim();
            String Correo = (EquiposGV.Rows[e.RowIndex].FindControl("txtCorreoElectronico") as TextBox).Text.Trim();
            String Pais = (EquiposGV.Rows[e.RowIndex].FindControl("txtPais") as TextBox).Text.Trim();
            String Calle = (EquiposGV.Rows[e.RowIndex].FindControl("txtCalle") as TextBox).Text.Trim();
            String Avenida = (EquiposGV.Rows[e.RowIndex].FindControl("txtAvenida") as TextBox).Text.Trim();
            String Ciudad = (EquiposGV.Rows[e.RowIndex].FindControl("txtCiudad") as TextBox).Text.Trim();
            String Zip = (EquiposGV.Rows[e.RowIndex].FindControl("txtZip_Code") as TextBox).Text.Trim();
            String Estado = (EquiposGV.Rows[e.RowIndex].FindControl("txtEstado") as TextBox).Text.Trim();
            String Referencia = (EquiposGV.Rows[e.RowIndex].FindControl("txtReferencia") as TextBox).Text.Trim();

            MySqlCommand update = new MySqlCommand("Update_Cliente", con);

            update.Parameters.Add(new MySqlParameter("P_codigo", Codigo));
            update.Parameters.Add(new MySqlParameter("P_nombre", Nombre));
            update.Parameters.Add(new MySqlParameter("P_Telefono", Telefono));
            update.Parameters.Add(new MySqlParameter("P_pagina", Pagina));
            update.Parameters.Add(new MySqlParameter("P_correo", Correo));
            update.Parameters.Add(new MySqlParameter("P_pais", Pais));
            update.Parameters.Add(new MySqlParameter("P_calle", Calle));
            update.Parameters.Add(new MySqlParameter("P_avenida", Avenida));
            update.Parameters.Add(new MySqlParameter("P_ciudad", Ciudad));
            update.Parameters.Add(new MySqlParameter("P_zip", Zip));
            update.Parameters.Add(new MySqlParameter("P_estado", Estado));
            update.Parameters.Add(new MySqlParameter("P_referencia", Referencia));

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
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
    public partial class ingreso_empleados : System.Web.UI.Page
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
            MySqlDataAdapter show = new MySqlDataAdapter("SELECT * FROM empleados", con);
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

                
                String PrimerN = (EquiposGV.FooterRow.FindControl("txtPrimer_NFooter") as TextBox).Text.Trim();
                String SegundoN = (EquiposGV.FooterRow.FindControl("txtSegundo_NFooter") as TextBox).Text.Trim();
                String PrimerA = (EquiposGV.FooterRow.FindControl("txtPrimer_AFooter") as TextBox).Text.Trim();
                String SegundoA = (EquiposGV.FooterRow.FindControl("txtSegundo_AFooter") as TextBox).Text.Trim();
                String Calle = (EquiposGV.FooterRow.FindControl("txtCalleFooter") as TextBox).Text.Trim();
                String Avenida = (EquiposGV.FooterRow.FindControl("txtAvenidaFooter") as TextBox).Text.Trim();
                String Casa = (EquiposGV.FooterRow.FindControl("txtNo_CasaFooter") as TextBox).Text.Trim();
                String Ciudad = (EquiposGV.FooterRow.FindControl("txtCiudadFooter") as TextBox).Text.Trim();
                String Departamento = (EquiposGV.FooterRow.FindControl("txtDepartamentoFooter") as TextBox).Text.Trim();
                String Referencia = (EquiposGV.FooterRow.FindControl("txtReferenciaFooter") as TextBox).Text.Trim();
                String Telefono = (EquiposGV.FooterRow.FindControl("txtTelefonoFooter") as TextBox).Text.Trim();

                String FechaN = (EquiposGV.FooterRow.FindControl("txtFecha_NacimientoFooter") as TextBox).Text.Trim();
                String FechaC = (EquiposGV.FooterRow.FindControl("txtFecha_ContratacionFooter") as TextBox).Text.Trim();
                String Salario = (EquiposGV.FooterRow.FindControl("txtSalarioFooter") as TextBox).Text.Trim();
                String idequipo = (EquiposGV.FooterRow.FindControl("txtId_EquipoFooter") as TextBox).Text.Trim();
                String idequipop = (EquiposGV.FooterRow.FindControl("txtId_EquipoPFooter") as TextBox).Text.Trim();
                String supervisor = (EquiposGV.FooterRow.FindControl("txtSupervisorFooter") as TextBox).Text.Trim();

                MySqlCommand insert = new MySqlCommand("Create_cliente", con);

                insert.Parameters.Add(new MySqlParameter("P_primerN", PrimerN));
                insert.Parameters.Add(new MySqlParameter("P_segundoN", SegundoN));
                insert.Parameters.Add(new MySqlParameter("P_primerA", PrimerA));
                insert.Parameters.Add(new MySqlParameter("P_segundoA", SegundoA));
                insert.Parameters.Add(new MySqlParameter("P_calle", Calle));
                insert.Parameters.Add(new MySqlParameter("P_avenida", Avenida));
                insert.Parameters.Add(new MySqlParameter("P_noCasa", Casa));
                insert.Parameters.Add(new MySqlParameter("P_ciudad", Ciudad));
                insert.Parameters.Add(new MySqlParameter("P_departamento", Departamento));
                insert.Parameters.Add(new MySqlParameter("P_referencia", Referencia));
                insert.Parameters.Add(new MySqlParameter("P_telefono", Telefono));
                insert.Parameters.Add(new MySqlParameter("P_fechaN", FechaN));
                insert.Parameters.Add(new MySqlParameter("P_fechaC", FechaC));
                insert.Parameters.Add(new MySqlParameter("P_Salario", FechaC));
                insert.Parameters.Add(new MySqlParameter("P_idequipo", 2));
                insert.Parameters.Add(new MySqlParameter("P_idequipoP", 2));
                

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
           

                String Codigo = (EquiposGV.Rows[e.RowIndex].FindControl("txtCodigo_de_EmpleadoFooter") as TextBox).Text.Trim();
                String PrimerN = (EquiposGV.Rows[e.RowIndex].FindControl("txtPrimer_NFooter") as TextBox).Text.Trim();
                String SegundoN = (EquiposGV.Rows[e.RowIndex].FindControl("txtSegundo_NFooter") as TextBox).Text.Trim();
                String PrimerA = (EquiposGV.Rows[e.RowIndex].FindControl("txtPrimer_AFooter") as TextBox).Text.Trim();
                String SegundoA = (EquiposGV.Rows[e.RowIndex].FindControl("txtSegundo_AFooter") as TextBox).Text.Trim();
                String Calle = (EquiposGV.Rows[e.RowIndex].FindControl("txtCalleFooter") as TextBox).Text.Trim();
                String Avenida = (EquiposGV.Rows[e.RowIndex].FindControl("txtAvenidaFooter") as TextBox).Text.Trim();
                String Casa = (EquiposGV.Rows[e.RowIndex].FindControl("txtNo_CasaFooter") as TextBox).Text.Trim();
                String Ciudad = (EquiposGV.Rows[e.RowIndex].FindControl("txtCiudadFooter") as TextBox).Text.Trim();
                String Departamento = (EquiposGV.Rows[e.RowIndex].FindControl("txtDepartamentoFooter") as TextBox).Text.Trim();
                String Referencia = (EquiposGV.Rows[e.RowIndex].FindControl("txtReferenciaFooter") as TextBox).Text.Trim();
                String Telefono = (EquiposGV.Rows[e.RowIndex].FindControl("txtTelefonoFooter") as TextBox).Text.Trim();

                String FechaN = (EquiposGV.Rows[e.RowIndex].FindControl("txtFecha_NacimientoFooter") as TextBox).Text.Trim();
                String FechaC = (EquiposGV.Rows[e.RowIndex].FindControl("txtFecha_ContratacionFooter") as TextBox).Text.Trim();
                String Salario = (EquiposGV.Rows[e.RowIndex].FindControl("txtSalarioFooter") as TextBox).Text.Trim();
                String idequipo = (EquiposGV.Rows[e.RowIndex].FindControl("txtId_EquipoFooter") as TextBox).Text.Trim();
                String idequipop = (EquiposGV.Rows[e.RowIndex].FindControl("txtId_EquipoPFooter") as TextBox).Text.Trim();
                String supervisor = (EquiposGV.Rows[e.RowIndex].FindControl("txtSupervisorFooter") as TextBox).Text.Trim();
           

            MySqlCommand update = new MySqlCommand("Update_Empleado", con);

            update.Parameters.Add(new MySqlParameter("P_id", Codigo));
            update.Parameters.Add(new MySqlParameter("P_primerN", PrimerN));
            update.Parameters.Add(new MySqlParameter("P_segundoN", SegundoN));
            update.Parameters.Add(new MySqlParameter("P_primerA", PrimerA));
            update.Parameters.Add(new MySqlParameter("P_segundoA", SegundoA));
            update.Parameters.Add(new MySqlParameter("P_calle", Calle));
            update.Parameters.Add(new MySqlParameter("P_avenida", Avenida));
            update.Parameters.Add(new MySqlParameter("P_noCasa", Casa));
            update.Parameters.Add(new MySqlParameter("P_departamento", Ciudad));
            update.Parameters.Add(new MySqlParameter("P_referencia", Departamento));
            update.Parameters.Add(new MySqlParameter("P_telefono", Referencia));
            update.Parameters.Add(new MySqlParameter("P_fechaN", Telefono));

            update.Parameters.Add(new MySqlParameter("P_fechaC", FechaN));
            update.Parameters.Add(new MySqlParameter("P_Salario", FechaC));
            update.Parameters.Add(new MySqlParameter("P_idequipo", Salario));
            update.Parameters.Add(new MySqlParameter("P_idequipop", idequipo));
            update.Parameters.Add(new MySqlParameter("P_supervisor", idequipop));

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
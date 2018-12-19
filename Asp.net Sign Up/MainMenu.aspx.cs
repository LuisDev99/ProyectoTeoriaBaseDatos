using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Asp.net_Sign_Up
{
    public partial class MainMenu : System.Web.UI.Page
    {
        bool isAdmin = false;


        protected void Page_Load(object sender, EventArgs e)
        {
            string userlogged = Session["username"].ToString(); // value of FirstNameTextBox.Text;
            string Name = Session["userpass"].ToString();

            if (userlogged == "admin")
                isAdmin = true;


        }

        protected void imCliente_Click(object sender, EventArgs e)
        {
            if(isAdmin)
                Response.Redirect("ingreso_clientes.aspx");
        }

        protected void imEquipo_Click(object sender, EventArgs e)
        {
            if (isAdmin)
                Response.Redirect("ingreso_equipos.aspx");
        }

        protected void imEmpleado_Click(object sender, EventArgs e)
        {
            if (isAdmin)
                Response.Redirect("ingreso_empleados.aspx");
        }

        protected void imEquipoTrabajo_Click(object sender, EventArgs e)
        {
            if (isAdmin)
                Response.Redirect("ingreso_equiposdetrabajo.aspx");
        }

        protected void imHerramienta_Click(object sender, EventArgs e)
        {
            if (isAdmin)
                Response.Redirect("ingreso_herramientas.aspx");
        }

        protected void imActividades_Click(object sender, EventArgs e)
        {
            Response.Redirect("ingreso_actividades.aspx");
        }

        protected void solOrdenDesarollo_Click(object sender, EventArgs e)
        {

            if (isAdmin)
                Response.Redirect("solicitud_ordendesarollo.aspx");
            
        }

        protected void Reportes_Click(object sender, EventArgs e)
        {
            if (isAdmin)
                Response.Redirect("Reportes.aspx");
        }

        protected void aprobacionOrdendesarollo_Click(object sender, EventArgs e)
        {
            if (isAdmin)
                Response.Redirect("aprobacion_ordendesarollo.aspx");
        }

        protected void listadoEquipo_Click(object sender, EventArgs e)
        {
            if (isAdmin)
                Response.Redirect("listado_equipos.aspx");
        }

        protected void cambioProyecto_Click(object sender, EventArgs e)
        {
            if (isAdmin)
                Response.Redirect("cambio_estado_proyecto");
        }
    }
}
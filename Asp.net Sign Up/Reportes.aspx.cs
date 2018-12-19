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
    public partial class Reportes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            using (MySqlConnection con = new MySqlConnection("server=127.0.0.1;user id=root; pwd = root; database=proyecto_teoria"))
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("select e.Codigo_emp , e.Primer_N, (select ee.Primer_N from empleados ee where e.Supervisor=ee.Codigo_emp) as Supervisor from empleados e;", con);
                MySqlDataReader dr = cmd.ExecuteReader();
                GridView1.DataSource = dr;
                GridView1.DataBind();
                con.Close();
            }

            using (MySqlConnection con = new MySqlConnection("server=127.0.0.1;user id=root; pwd = root; database=proyecto_teoria"))
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("select * from orden_desarrollo;", con);
                MySqlDataReader dr = cmd.ExecuteReader();
                GridView2.DataSource = dr;
                GridView2.DataBind();
                con.Close();
            }

            using (MySqlConnection con = new MySqlConnection("server=127.0.0.1;user id=root; pwd = root; database=proyecto_teoria"))
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("select * from orden_desarrollo left outer join project on orden_desarrollo.Codigo_ord = project.Orden_id where project.Orden_id is null;", con);
                MySqlDataReader dr = cmd.ExecuteReader();
                GridView2.DataSource = dr;
                GridView2.DataBind();
                con.Close();
            }

            using (MySqlConnection con = new MySqlConnection("server=127.0.0.1;user id=root; pwd = root; database=proyecto_teoria"))
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("select orden_desarrollo.Codigo_ord, project.Estado from orden_desarrollo inner join project on orden_desarrollo.Codigo_ord = project.Orden_id; ", con);
                MySqlDataReader dr = cmd.ExecuteReader();
                GridView3.DataSource = dr;
                GridView3.DataBind();
                con.Close();
            }

            using (MySqlConnection con = new MySqlConnection("server=127.0.0.1;user id=root; pwd = root; database=proyecto_teoria"))
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("select empleados.Codigo_emp, empleados.Primer_N, empleados.Primer_A, teams.Nombre_Rol from empleados inner join teams where empleados.Id_Equipo = teams.Codigo_team; ", con);
                MySqlDataReader dr = cmd.ExecuteReader();
                GridView4.DataSource = dr;
                GridView4.DataBind();
                con.Close();
            }

            using (MySqlConnection con = new MySqlConnection("server=127.0.0.1;user id=root; pwd = root; database=proyecto_teoria"))
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("select empleados.Codigo_emp, empleados.Primer_N, empleados.Primer_A, teamproject.Nombre from empleados inner join teamproject where empleados.Id_EquipoP = teamproject.Codigo_teamp group by teamproject.Nombre;", con);
                MySqlDataReader dr = cmd.ExecuteReader();
                GridView5.DataSource = dr;
                GridView5.DataBind();
                con.Close();
            }

            using (MySqlConnection con = new MySqlConnection("server=127.0.0.1;user id=root; pwd = root; database=proyecto_teoria"))
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("select  actividades.Id_actividad, actividades.Nombre, empleados.Codigo_emp, empleados.Primer_N from actividades inner join actividades_por_empleado on actividades.Id_actividad = actividades_por_empleado.id_actividad inner join empleados on actividades_por_empleado.id_empleado_fk1 = empleados.Codigo_emp where actividades_por_empleado.id_proyecto_fk=\"PRJ - 12\"; ", con);
                MySqlDataReader dr = cmd.ExecuteReader();
                GridView6.DataSource = dr;
                GridView6.DataBind();
                con.Close();
            }

            using (MySqlConnection con = new MySqlConnection("server=127.0.0.1;user id=root; pwd = root; database=proyecto_teoria"))
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("select  actividades.Id_actividad, actividades.Nombre, empleados.Codigo_emp, empleados.Primer_N from actividades inner join actividades_por_empleado on actividades.Id_actividad = actividades_por_empleado.id_actividad inner join empleados on actividades_por_empleado.id_empleado_fk1 = empleados.Codigo_emp group by empleados.Codigo_emp;", con);
                MySqlDataReader dr = cmd.ExecuteReader();
                GridView7.DataSource = dr;
                GridView7.DataBind();
                con.Close();
            }

            //using (MySqlConnection con = new MySqlConnection("server=127.0.0.1;user id=root; pwd = root; database=proyecto_teoria"))
            //{
            //    con.Open();
            //    MySqlCommand cmd = new MySqlCommand("select tools.Nombre, empleados.Primer_N from empleados inner join teamproject on empleados.Id_EquipoP = teamproject.Codigo_teamp inner join project on project.id_teamproject_fk = teamproject.Codigo_teamp inner join herramientas_por_proyecto on project;", con);
            //    MySqlDataReader dr = cmd.ExecuteReader();
            //    GridView8.DataSource = dr;
            //    GridView8.DataBind();
            //    con.Close();
            //}

            using (MySqlConnection con = new MySqlConnection("server=127.0.0.1;user id=root; pwd = root; database=proyecto_teoria"))
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("select project.Nombre_Proyecto, project.Codigo_pro, count(*) from project inner join teamproject on project.id_teamproject_fk = teamproject.Codigo_teamp group by project.id_teamproject_fk; ", con);
                MySqlDataReader dr = cmd.ExecuteReader();
                GridView9.DataSource = dr;
                GridView9.DataBind();
                con.Close();
            }

            using (MySqlConnection con = new MySqlConnection("server=127.0.0.1;user id=root; pwd = root; database=proyecto_teoria"))
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("select project.Nombre_Proyecto, project.Codigo_pro, count(*) from empleados inner join teamproject on empleados.Id_EquipoP = teamproject.Codigo_teamp inner join project on project.id_teamproject_fk = teamproject.Codigo_teamp group by empleados.Codigo_emp; ", con);
                MySqlDataReader dr = cmd.ExecuteReader();
                GridView10.DataSource = dr;
                GridView10.DataBind();
                con.Close();
            }

            using (MySqlConnection con = new MySqlConnection("server=127.0.0.1;user id=root; pwd = root; database=proyecto_teoria"))
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("select clientes.Nombre as Cliente, project.Nombre_proyecto, project.Estado from clientes inner join orden_desarrollo on clientes.Codigo_clie = orden_desarrollo.Id_cliente inner join project on orden_desarrollo.Codigo_ord = project.Orden_id where project.Estado =\"Done\";", con);
                MySqlDataReader dr = cmd.ExecuteReader();
                GridView11.DataSource = dr;
                GridView11.DataBind();
                con.Close();
            }

            using (MySqlConnection con = new MySqlConnection("server=127.0.0.1;user id=root; pwd = root; database=proyecto_teoria"))
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("select e.Codigo_emp , e.Primer_N, (select ee.Primer_N from empleados ee where e.Supervisor=ee.Codigo_emp) as Supervisor from empleados e;", con);
                MySqlDataReader dr = cmd.ExecuteReader();
                GridView12.DataSource = dr;
                GridView12.DataBind();
                con.Close();
            }


        }
    }
}
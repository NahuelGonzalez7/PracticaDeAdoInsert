using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Datos.AdmModels;
using Entidades.Models;

namespace WebMedicos
{
    public partial class VistaMedico : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            mostrarMedicos();
            llenarCombo();
        }

        private void mostrarMedicos()
        {
            if (!Page.IsPostBack)
            {
                gridMedicos.DataSource = AdminMedico.listar(); //Enlace de datos
                gridMedicos.DataBind(); //Visualizar los datos
            }
        }

        private void llenarCombo()
        {
            DataTable dt = AdminEspecialidad.Listar();
            ddlEspecialidad.DataSource = dt;
            ddlEspecialidad.DataValueField = dt.Columns["Id"].ToString();
            ddlEspecialidad.DataTextField = dt.Columns["Nombre"].ToString();
            ddlEspecialidad.DataBind();
        }
        protected void btnListar_Click(object sender, EventArgs e)
        {
            mostrarMedicos();
        }

        protected void btnInsertar_Click(object sender, EventArgs e)
        {
            Medico medico = new Medico()
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                NroMatricula = Convert.ToInt32(txtNroMatricula.Text),
                EspecialidadId = Convert.ToInt32(ddlEspecialidad.SelectedValue)
        };

            int filasAfectadas = AdminMedico.Crear(medico);

            if (filasAfectadas > 0)
            {
                mostrarMedicos();
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);

            int filasAfectadas = AdminMedico.eliminar(id);

            if (filasAfectadas > 0)
            {
                mostrarMedicos();
            }
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            Medico medico = new Medico()
            {
                ID = Convert.ToInt32(txtID.Text),
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                NroMatricula = Convert.ToInt32(txtNroMatricula.Text),
                EspecialidadId = Convert.ToInt32(ddlEspecialidad.SelectedValue)
            };

            int filasAfectadas = AdminMedico.modificar(medico);

            if (filasAfectadas > 0)
            {
                mostrarMedicos();
            }
        }
    }
}
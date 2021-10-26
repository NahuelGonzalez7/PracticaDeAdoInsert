using Datos.AdmModels;
using Entidades.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsMedicos
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mostrarContent();
            llenarComboEspecialidades();
            LlenarComboTraerPorEspecialidad();
        }

        private void mostrarContent()
        {
            gridMedicos.DataSource = AdminMedico.listar();
        }

        private void btnGuardarMedico_Click(object sender, EventArgs e)
        {
            Medico medico = new Medico()
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                NroMatricula = Convert.ToInt32(txtNroMatricula.Text),
                EspecialidadId = Convert.ToInt32(cbEspecialidades.SelectedValue)
            };

             int filasAfectadas = AdminMedico.Crear(medico);

             if(filasAfectadas > 0)
            {
                MessageBox.Show("Insert ok");
            }
        }

        private void llenarComboEspecialidades()
        {
            DataTable especialidades = AdminEspecialidad.Listar();

            cbEspecialidades.DataSource = especialidades;
            cbEspecialidades.DisplayMember = especialidades.Columns["Nombre"].ToString();
            cbEspecialidades.ValueMember = especialidades.Columns["Id"].ToString();
        }

        private void LlenarComboTraerPorEspecialidad()
        {
            DataTable especialidadID = AdminEspecialidad.Listar();

            cbTraerEspecialidad.DataSource = especialidadID;
            cbTraerEspecialidad.DisplayMember = especialidadID.Columns["Nombre"].ToString();
            cbTraerEspecialidad.ValueMember = especialidadID.Columns["Id"].ToString();

            DataRow fila = especialidadID.NewRow();
            fila["Id"] = 0;
            fila["Nombre"] = "[TODAS]";
            especialidadID.Rows.InsertAt(fila, 0);

        }

        private void cbTraerEspecialidad_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int categoriaID = Convert.ToInt32(cbTraerEspecialidad.SelectedValue);

            if (categoriaID == 0)
            {
                mostrarContent();
            }
            else
            {
                gridMedicos.DataSource = AdminMedico.listar(categoriaID);
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB3_SEM1_2803.Tareas
{
    public partial class frmTareas : Form
    {

        ClsConexionTareas conexionTareas = new ClsConexionTareas();
        public int usuarioId;

        public frmTareas(int id)
        {
            InitializeComponent();
            usuarioId = id;
            CargarTareas();

            cboPrioridad.Items.Add("Alta");
            cboPrioridad.Items.Add("Media");
            cboPrioridad.Items.Add("Baja");

            cboEstadoNuevo.Items.Add("Pendiente");
            cboEstadoNuevo.Items.Add("En Proceso");
            cboEstadoNuevo.Items.Add("Completada");


            using (SqlConnection conn = conexionTareas.conexion())
            {
                string query = "SELECT Id, Nombre FROM Usuario";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cboUsuarios.DataSource = dt;
                cboUsuarios.DisplayMember = "Nombre";
                cboUsuarios.ValueMember = "Id";
            }
        }
        public void CargarTareas()
        {
            dgvTareas.DataSource = conexionTareas.ConsultaTareaUsuario(usuarioId);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string titulo = txtTitulo.Text;
            string descripcion = txtDescripcion.Text;
            string prioridad = cboPrioridad.Text;
            DateTime fechaVencimiento = dtpFecha.Value;
            int usuarioAsignadoId = Convert.ToInt32(cboUsuarios.SelectedValue);

            // Crear tarea con estado "Pendiente"
            conexionTareas.InsertarTarea(titulo, descripcion, prioridad, fechaVencimiento, usuarioAsignadoId);
            CargarTareas();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int idTarea = Convert.ToInt32(txtTareaActualizar.Text);
            conexionTareas.ActualizarTarea(idTarea, cboEstadoNuevo.Text);
            CargarTareas();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idTarea = Convert.ToInt32(txtIdEliminar.Text);
            conexionTareas.Eliminar(idTarea);
            CargarTareas();
        }
    }
}

using LAB3_SEM1_2803.AgendaContactos;
using LAB3_SEM1_2803.Tareas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
// metodo para la validacion de numeros en el código
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB3_SEM1_2803
{
    public partial class GestorInventario : Form
    {
        ClsConexion conexion = new ClsConexion();

        public GestorInventario()
        {
            
            InitializeComponent();
            frmLogin ingreso = new frmLogin();
            ingreso.Show();
            frmAgenda Agenda = new frmAgenda();
            Agenda.Show();

            /*numPrecio.Minimum = 1;
            numPrecio.Maximum = 10000;

            numStock.Minimum = 1;
            numStock.Maximum = 100;*/

            txtCodigo.MaxLength = 4;
            txtDescripcion.MaxLength = 125;
            txtNombre.MaxLength = 100;

            cboCategoria.Text = "-";

            using (SqlConnection conn = conexion.conexion())
            {
                string query = "SELECT Id, Nombre FROM Categorias";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cboCategoria.DataSource = dt;
                cboCategoria.DisplayMember = "Nombre";
                cboCategoria.ValueMember = "Id";
            }
            dgvProductos.DataSource = conexion.ConsultaTotal();


        }

        public String Error = "No se han cargado los datos";

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                int Codigo = Convert.ToInt32(txtCodigo.Text);
                string Nombre = txtNombre.Text;
                string Descripcion = txtDescripcion.Text;
                decimal Precio = Convert.ToDecimal(txtPrecio.Text);
                int Stock = Convert.ToInt32(txtStock.Text);
                int CategoriaId = Convert.ToInt32(cboCategoria.SelectedValue);
                //conexion.AgregarProductos(Convert.ToInt32(txtCodigo.Text), txtNombre.Text, txtDescripcion.Text,
                //Convert.ToDecimal(txtPrecio.Text), Convert.ToInt32(txtStock.Text), Convert.ToInt32(cboCategoria));

                conexion.AgregarProductos(Codigo, Nombre, Descripcion, Precio, Stock, CategoriaId);

                //MessageBox.Show("Producto agregado");
                dgvProductos.DataSource = conexion.ConsultaTotal();
            }
            catch (Exception ex)
            {
                Error = ex.Message;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (optNombre.Checked)
            {
                string consulta = txtConsulta.Text;
                dgvProductos.DataSource = conexion.ConsultaNombre(consulta);
            }
            else if(optCodigo.Checked)
            {
                int consulta = Convert.ToInt32(txtConsulta.Text);
                dgvProductos.DataSource = conexion.ConsultaCodigo(consulta);
            }
            else if(optCategoria.Checked)
            {
                string consulta = txtConsulta.Text;
                dgvProductos.DataSource = conexion.ConsultaCategoria(consulta);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int Codigo = Convert.ToInt32(txtCodigoActualizar.Text);
            decimal nuevoPrecio = Convert.ToDecimal(txtPrecioActualizar.Text);
            conexion.Actualizar(Codigo, nuevoPrecio);

            txtPrecioActualizar.Clear();
            txtCodigoActualizar.Clear();
            dgvProductos.DataSource = conexion.ConsultaTotal();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int Codigo = Convert.ToInt32(txtCodigoEliminar.Text);
            conexion.Eliminar(Codigo);
            txtCodigoEliminar.Clear();
            dgvProductos.DataSource = conexion.ConsultaTotal();
        }

        private void btnTablaCompleta_Click(object sender, EventArgs e)
        {
            dgvProductos.DataSource = conexion.ConsultaTotal();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Text files (*.txt)|*.txt";
            if (save.ShowDialog() == DialogResult.OK)
            {
                conexion.GenerarReporte(dgvProductos, save.FileName);
            }
        }
    }
}

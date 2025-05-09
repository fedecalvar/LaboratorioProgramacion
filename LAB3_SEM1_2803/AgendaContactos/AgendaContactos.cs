using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB3_SEM1_2803.AgendaContactos
{
    public partial class frmAgenda : Form
    {
        ClsConexionAgenda conexion = new ClsConexionAgenda();
        public frmAgenda()
        {
            InitializeComponent();
            conexion.CargarContactos(tvContactos);
            cboCategoria.Items.Add("Amigos");
            cboCategoria.Items.Add("Familia");
            cboCategoria.Items.Add("Trabajo");
            cboCategoria.Items.Add("Otros");
        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            string Nombre = txtNombre.Text;
            string Apellido = txtApellido.Text;
            string Telefono = txtNumero.Text;
            string Correo = txtCorreo.Text;
            conexion.Insertar(Nombre, Apellido, Telefono, Correo, cboCategoria.Text);
            conexion.CargarContactos(tvContactos);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string nombreAct = txtNombreAct.Text;
            string ApellidoAct = txtApellidoAct.Text;
            string numeroAct = txtNuevoNumero.Text;
            conexion.Actualizar(nombreAct, ApellidoAct, numeroAct);
            conexion.CargarContactos(tvContactos);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string nombreEliminar = txtNombreEliminar.Text;
            string apellidoEliminar = txtApellidoEliminar.Text;
            conexion.Eliminar(nombreEliminar, apellidoEliminar);
            conexion.CargarContactos(tvContactos);
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            conexion.CargarContactos(tvContactos);
        }

        private void btnBuscarOpt_Click(object sender, EventArgs e)
        {
            string dato = txtDato.Text;
            
            if (optNombre.Checked)
            {
                conexion.consultaNombre(tvContactos, dato);
            }
            else if (optNumero.Checked)
            {
                conexion.consultaNumero(tvContactos, dato);
            }
            else if (optCorreo.Checked)
            {
                conexion.consultaCorreo(tvContactos, dato);
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();

            // Determinar qué formato eligió el usuario
            if (optCsv.Checked)
            {
                saveFile.Filter = "CSV Files (*.csv)|*.csv";
                saveFile.Title = "Exportar contactos como CSV";

                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    conexion.ExportarContactosCSV(saveFile.FileName);
                }
            }
            else if (optVCard.Checked)
            {
                saveFile.Filter = "vCard Files (*.vcf)|*.vcf";
                saveFile.Title = "Exportar contactos como vCard";

                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    conexion.ExportarContactosVCard(saveFile.FileName);
                }
            }
        }
    }
}

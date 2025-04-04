using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB3_SEM1_2803
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //NumPrecio.Minimum = 1;
            NumPrecio.Maximum = 10000;

            //numStock.Minimum = 1;
            numStock.Maximum = 100;

            txtCodigo.MaxLength = 4;
            txtDesc.MaxLength = 125;
            txtNombre.MaxLength = 100;
        }

        public String Error = "No se han cargado los datos";

        private void Form1_Load(object sender, EventArgs e)
        {
            /*Productos productos = new Productos();

            if (productos.Error != "")
            {
                MessageBox.Show("Error al cargar los productos: " + productos.Error);
                return;
            }

            // Limpiar primero (por si se llama más de una vez)
            lstProductos.Items.Clear();

            // Cargar productos al ListBox
            foreach (DataRow fila in productos.dtProductos.Rows)
            {
                string nombre = fila["Nombre"].ToString(); // ajustá "Nombre" al nombre real de tu columna
                lstProductos.Items.Add(nombre);*/
        }

        private bool validarDatos()
        {
            bool Resultado = true;

            try
            {
                if (NumPrecio.Value == 0)
                {
                    MessageBox.Show("El precio no puede ser cero.", "Valor inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Resultado = false;
                }

                if (numStock.Value == 0)
                {
                    MessageBox.Show("El stock no puede ser cero.", "Valor inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Resultado = false;
                }
            }
            catch (Exception ex)
            {
                Error = ex.Message;
            }

            return Resultado;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (validarDatos())
                {
                    int Codigo = int.Parse(txtCodigo.Text);
                    String Nombre = txtNombre.Text;
                    String Descripcion = txtDesc.Text;
                    int Precio = (int)NumPrecio.Value;
                    int Stock = (int)NumPrecio.Value;
                    Productos p = new Productos();
                    //Participantes p = new Participantes();
                    p.NuevoParticipante(Codigo, Nombre, Descripcion, Precio, Stock);

                }
            }
            catch (Exception ex)
            {
                Error = ex.Message;
            }
            finally
            {
                txtCodigo.Text = "";
                txtNombre.Text = "";
                txtDesc.Text = "";

                numStock.Value = 0;
                NumPrecio.Value = 0;
            }

        }
    }
}

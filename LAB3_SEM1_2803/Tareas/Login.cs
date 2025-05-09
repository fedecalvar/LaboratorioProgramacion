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
    public partial class frmLogin : Form
    {

        ClsConexionTareas conexion = new ClsConexionTareas();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string nombre = txtUsuario.Text;
            string clave = txtContraseña.Text;

            int? usuarioID = conexion.IniciarSesion(nombre, clave);

            if (usuarioID != null)
            {
                frmTareas tareas = new frmTareas(usuarioID.Value);
                this.Hide();
                tareas.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }
    }
}

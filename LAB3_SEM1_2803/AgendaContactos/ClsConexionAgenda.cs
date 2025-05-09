using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB3_SEM1_2803.AgendaContactos
{
    internal class ClsConexionAgenda
    {

        private string cadenaConexion = "Server=localhost;Database=Agenda;Trusted_Connection=True;";

        public SqlConnection conexion()
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            conexion.Open();
            return conexion;
        }
        public void Insertar(string nombre, string apellido, string telefono, string correo, string categoria)
        {
            using (SqlConnection conn = conexion())
            {
                string query = @"
            INSERT INTO Contactos (Nombre, Apellido, Telefono, Correo, Categoria)
            VALUES (@Nombre, @Apellido, @Telefono, @Correo, @Categoria)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Apellido", apellido);
                cmd.Parameters.AddWithValue("@Telefono", telefono);
                cmd.Parameters.AddWithValue("@Correo", correo);
                cmd.Parameters.AddWithValue("@Categoria", categoria);

                cmd.ExecuteNonQuery();
                MessageBox.Show("✅ Contacto agregado.");
            }
        }

        public void Actualizar(string nombre, string apellido, string nuevoTelefono)
        {
            using (SqlConnection conn = conexion())
            {
                string query = @"
            UPDATE Contactos 
            SET Telefono = @NuevoTelefono 
            WHERE Nombre = @Nombre AND Apellido = @Apellido";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@NuevoTelefono", nuevoTelefono);
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Apellido", apellido);

                int filas = cmd.ExecuteNonQuery();
                MessageBox.Show("🔄 Contacto actualizado.");
            }
        }

        public void Eliminar(string nombre, string apellido)
        {
            using (SqlConnection conn = conexion())
            {
                string query = @"
                DELETE FROM Contactos 
                WHERE Nombre = @Nombre AND Apellido = @Apellido";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Apellido", apellido);

                int filas = cmd.ExecuteNonQuery();
                if (filas > 0)
                    MessageBox.Show("❌ Contacto eliminado.");
            }
        }

        public void CargarContactos(TreeView treeView)
        {
            // aprender a manejarlo bien
            using (SqlConnection conn = conexion())
            {

                string query = @"
                SELECT Categoria, Nombre, Apellido, Telefono, Correo 
                FROM Contactos
                ORDER BY Categoria, Apellido, Nombre";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                treeView.Nodes.Clear();

                Dictionary<string, TreeNode> categorias = new Dictionary<string, TreeNode>();

                while (reader.Read())
                {
                    string categoria = reader["Categoria"].ToString();
                    string nombre = reader["Nombre"].ToString();
                    string apellido = reader["Apellido"].ToString();
                    string telefono = reader["Telefono"].ToString();
                    string correo = reader["Correo"].ToString();

                    string info = apellido + ", " + nombre + ", " + telefono + ", " + correo;

                    // Crear nodo de categoría si no existe
                    if (!categorias.ContainsKey(categoria))
                    {
                        TreeNode nodoCategoria = new TreeNode(categoria);
                        categorias[categoria] = nodoCategoria;
                        treeView.Nodes.Add(nodoCategoria);
                    }

                    categorias[categoria].Nodes.Add(new TreeNode(info));
                }

                reader.Close();
                // desplegar y mostrar todos
                treeView.ExpandAll();
            }
        }

        public void consultaNombre(TreeView treeView, string nombre)
        {
            using (SqlConnection conn = conexion())
            {
                string query = @"
            SELECT Categoria, Nombre, Apellido, Telefono, Correo
            FROM Contactos
            WHERE Nombre LIKE @nombre
            ORDER BY Categoria, Apellido, Nombre";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nombre", "%" + nombre + "%");

                SqlDataReader reader = cmd.ExecuteReader();

                treeView.Nodes.Clear();
                Dictionary<string, TreeNode> categorias = new Dictionary<string, TreeNode>();

                while (reader.Read())
                {
                    string categoria = reader["Categoria"].ToString();
                    string info = $"{reader["Apellido"]}, {reader["Nombre"]}, {reader["Telefono"]}, {reader["Correo"]}";

                    if (!categorias.ContainsKey(categoria))
                    {
                        TreeNode nodoCategoria = new TreeNode(categoria);
                        categorias[categoria] = nodoCategoria;
                        treeView.Nodes.Add(nodoCategoria);
                    }

                    categorias[categoria].Nodes.Add(new TreeNode(info));
                }

                reader.Close();
                treeView.ExpandAll();
            }
        }

        public void consultaNumero(TreeView treeView, string telefono)
        {
            using (SqlConnection conn = conexion())
            {
                string query = @"
            SELECT Categoria, Nombre, Apellido, Telefono, Correo
            FROM Contactos
            WHERE Telefono LIKE @telefono
            ORDER BY Categoria, Apellido, Nombre";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@telefono", "%" + telefono + "%");

                SqlDataReader reader = cmd.ExecuteReader();

                treeView.Nodes.Clear();
                Dictionary<string, TreeNode> categorias = new Dictionary<string, TreeNode>();

                while (reader.Read())
                {
                    string categoria = reader["Categoria"].ToString();
                    string info = $"{reader["Apellido"]}, {reader["Nombre"]}, {reader["Telefono"]}, {reader["Correo"]}";

                    if (!categorias.ContainsKey(categoria))
                    {
                        TreeNode nodoCategoria = new TreeNode(categoria);
                        categorias[categoria] = nodoCategoria;
                        treeView.Nodes.Add(nodoCategoria);
                    }

                    categorias[categoria].Nodes.Add(new TreeNode(info));
                }

                reader.Close();
                treeView.ExpandAll();
            }
        }

        public void consultaCorreo(TreeView treeView, string correo)
        {
            using (SqlConnection conn = conexion())
            {
                string query = @"
            SELECT Categoria, Nombre, Apellido, Telefono, Correo
            FROM Contactos
            WHERE Correo LIKE @correo
            ORDER BY Categoria, Apellido, Nombre";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@correo", "%" + correo + "%");

                SqlDataReader reader = cmd.ExecuteReader();

                treeView.Nodes.Clear();
                Dictionary<string, TreeNode> categorias = new Dictionary<string, TreeNode>();

                while (reader.Read())
                {
                    string categoria = reader["Categoria"].ToString();
                    string info = $"{reader["Apellido"]}, {reader["Nombre"]}, {reader["Telefono"]}, {reader["Correo"]}";

                    if (!categorias.ContainsKey(categoria))
                    {
                        TreeNode nodoCategoria = new TreeNode(categoria);
                        categorias[categoria] = nodoCategoria;
                        treeView.Nodes.Add(nodoCategoria);
                    }

                    categorias[categoria].Nodes.Add(new TreeNode(info));
                }

                reader.Close();
                treeView.ExpandAll();
            }
        }

        public void ExportarContactosVCard(string rutaArchivo)
        {
            using (SqlConnection conn = conexion())
            {
                string query = "SELECT Nombre, Apellido, Telefono, Correo FROM Contactos";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                using (StreamWriter sw = new StreamWriter(rutaArchivo, false, Encoding.UTF8))
                {
                    while (reader.Read())
                    {
                        string nombre = reader["Nombre"].ToString();
                        string apellido = reader["Apellido"].ToString();
                        string tel = reader["Telefono"].ToString();
                        string correo = reader["Correo"].ToString();

                        sw.WriteLine("BEGIN:VCARD");
                        sw.WriteLine("VERSION:3.0");
                        sw.WriteLine($"N:{apellido};{nombre};;;");
                        sw.WriteLine($"FN:{nombre} {apellido}");
                        sw.WriteLine($"TEL:{tel}");
                        sw.WriteLine($"EMAIL:{correo}");
                        sw.WriteLine("END:VCARD");
                        sw.WriteLine(); // espacio entre contactos
                    }
                }

                reader.Close();
            }

            MessageBox.Show("✅ Contactos exportados a vCard.");
        }

        public void ExportarContactosCSV(string rutaArchivo)
        {
            using (SqlConnection conn = conexion())
            {
                string query = "SELECT Nombre, Apellido, Telefono, Correo, Categoria FROM Contactos";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                using (StreamWriter sw = new StreamWriter(rutaArchivo, false, Encoding.UTF8))
                {
                    sw.WriteLine("Nombre,Apellido,Telefono,Correo,Categoria"); // encabezado

                    while (reader.Read())
                    {
                        string linea = $"{reader["Nombre"]},{reader["Apellido"]},{reader["Telefono"]},{reader["Correo"]},{reader["Categoria"]}";
                        sw.WriteLine(linea);
                    }
                }

                reader.Close();
            }

            MessageBox.Show("✅ Contactos exportados a CSV.");
        }


    }
}

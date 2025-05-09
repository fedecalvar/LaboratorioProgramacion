using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB3_SEM1_2803.Tareas
{
    internal class ClsConexionTareas
    {
        private string cadenaConexion = "Server=localhost;Database=Tareas;Trusted_Connection=True;";

        public SqlConnection conexion()
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            conexion.Open();
            return conexion;
        }

        // "?" por que la funcion puede devolver un numero entero o null. En este caso el id del usuario
        public int? IniciarSesion(string nombre, string clave)
        {
            using (SqlConnection conn = conexion())
            {
                string query = "SELECT Id FROM Usuario WHERE Nombre = @nombre AND Contraseña = @clave";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@clave", clave);

                object result = cmd.ExecuteScalar();
                if (result != null)
                    return Convert.ToInt32(result);
                else
                    return null;
            }
        }

        public DataTable ConsultaTareaUsuario(int usuarioId)
        {
            using (SqlConnection conn = conexion())
            {
                string query = "SELECT * FROM Tarea WHERE UsuarioId = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", usuarioId);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public void InsertarTarea(string titulo, string descripcion, string prioridad, DateTime fecha, int usuarioId)
        {
            using (SqlConnection conn = conexion())
            {
                string query = @"INSERT INTO Tarea (Titulo, Descripcion, Prioridad, FechaVencimiento, Estado, UsuarioId)
                                 VALUES (@titulo, @descripcion, @prioridad, @fecha, 'Pendiente', @usuarioId)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@titulo", titulo);
                cmd.Parameters.AddWithValue("@descripcion", descripcion);
                cmd.Parameters.AddWithValue("@prioridad", prioridad);
                cmd.Parameters.AddWithValue("@fecha", fecha);
                cmd.Parameters.AddWithValue("@usuarioId", usuarioId);
                cmd.ExecuteNonQuery();
                MessageBox.Show("✅ Producto agregado con éxito.");
            }
        }

        public void ActualizarTarea(int idTarea, string nuevoEstado)
        {
            using (SqlConnection conn = conexion())
            {
                string query = "UPDATE Tarea SET Estado = @estado WHERE Id = @id"; ;
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@estado", nuevoEstado);
                cmd.Parameters.AddWithValue("@id", idTarea);
                cmd.ExecuteNonQuery();
                MessageBox.Show("🔄 Tarea actualizada.");
            }
        }

        public void Eliminar(int idTarea)
        {
            using (SqlConnection conn = conexion())
            {
                string query = "DELETE FROM Tarea WHERE Id = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", idTarea);
                cmd.ExecuteNonQuery();
                MessageBox.Show("❌ Tarea eliminada.");
            }
        }

    }
}
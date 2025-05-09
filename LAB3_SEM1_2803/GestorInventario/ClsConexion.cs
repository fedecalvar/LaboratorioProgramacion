using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB3_SEM1_2803
{
    internal class ClsConexion
    {
        private string cadenaConexion = "Server=localhost;Database=Productos;Trusted_Connection=True;";

        // SqlConnection establece la conexion con la bdd
        public SqlConnection conexion()
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            conexion.Open();
            return conexion;
        }

        public void AgregarProductos(int Codigo, string Nombre, string Descripcion,
            decimal Precio, int Stock,int CategoriaId)
        {
            using (SqlConnection conn = conexion())
            {
                string query = @"INSERT INTO Productos (Codigo, Nombre, Descripcion, Precio, Stock ,CategoriaId)
                             VALUES (@Codigo, @nombre, @descripcion, @precio, @stock, @categoriaId)";

                // se usa para ejecutar la query. Le paso la consulta y la conexion
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("Codigo", Codigo);
                cmd.Parameters.AddWithValue("Nombre", Nombre);
                cmd.Parameters.AddWithValue("Descripcion", Descripcion);
                cmd.Parameters.AddWithValue("Precio", Precio);
                cmd.Parameters.AddWithValue("Stock", Stock);
                cmd.Parameters.AddWithValue("CategoriaId", CategoriaId);

                // ejecutamos la consulta
                cmd.ExecuteNonQuery();

                //Console.WriteLine("✅ Producto agregado con éxito.");
                MessageBox.Show("✅ Producto agregado con éxito.");
            }
        }

        public void Actualizar(int Codigo, decimal PrecioNuevo)
        {
            using (SqlConnection conn = conexion())
            {
                string updateQuery = "UPDATE Productos SET precio = @Precio WHERE codigo = @Codigo";

                SqlCommand cmd = new SqlCommand(updateQuery, conn);

                cmd.Parameters.AddWithValue("@Precio", PrecioNuevo);
                cmd.Parameters.AddWithValue("@Codigo", Codigo);
                cmd.ExecuteNonQuery();
                MessageBox.Show("🔄 Producto actualizado.");
            }

        }

        public void Eliminar(int Codigo)
        {
            using (SqlConnection conn = conexion())
            {
                string deleteQuery = "DELETE FROM Productos WHERE Codigo = @codigo";

                SqlCommand cmd = new SqlCommand(deleteQuery, conn);
                cmd.Parameters.AddWithValue("@codigo", Codigo);
                cmd.ExecuteNonQuery();
                MessageBox.Show("❌ Producto eliminado.");

            }
        }

        public DataTable ConsultaTotal()
        {
            DataTable dt = new DataTable();

            // metodo de conexion
            using (SqlConnection conn = conexion())
            {
                string query = @"
                SELECT 
                    P.Codigo,
                    P.Nombre,
                    P.Descripcion,
                    P.Precio,
                    P.Stock,
                    C.Nombre AS Categoria
                FROM 
                    Productos P
                JOIN 
                    Categorias C ON P.CategoriaId = C.Id";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.Fill(dt); // llena el DataTable
            }

            return dt;
        }

        public DataTable ConsultaNombre(string Nombre)
        {
            DataTable dt = new DataTable();

            // metodo de conexion
            using (SqlConnection conn = conexion())
            {
                string query = @"
                SELECT 
                    P.Codigo,
                    P.Nombre,
                    P.Descripcion,
                    P.Precio,
                    P.Stock,
                    C.Nombre AS Categoria
                FROM 
                    Productos P
                JOIN 
                    Categorias C ON P.CategoriaId = C.Id
                WHERE 
                    P.Nombre = @nombre";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nombre", Nombre);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }

            return dt;
        }

        public DataTable ConsultaCodigo(int Codigo)
        {
            DataTable dt = new DataTable();

            // metodo de conexion
            using (SqlConnection conn = conexion())
            {
                string query = @"
                SELECT 
                    P.Codigo,
                    P.Nombre,
                    P.Descripcion,
                    P.Precio,
                    P.Stock,
                    C.Nombre AS Categoria
                FROM 
                    Productos P
                JOIN 
                    Categorias C ON P.CategoriaId = C.Id
                WHERE 
                    P.Codigo = @codigo";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@codigo", Codigo);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }

            return dt;
        }

        public DataTable ConsultaCategoria(string Consulta)
        {
            DataTable dt = new DataTable();

            // metodo de conexion
            using (SqlConnection conn = conexion())
            {
                string query = @"
                SELECT 
                    P.Codigo,
                    P.Nombre,
                    P.Descripcion,
                    P.Precio,
                    P.Stock,
                    C.Nombre AS Categoria
                FROM 
                    Productos P
                JOIN 
                    Categorias C ON P.CategoriaId = C.Id
                WHERE 
                    C.Nombre = @categoria";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@categoria", Consulta);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }

            return dt;
        }

        public void GenerarReporte(DataGridView dgv, string archivoDestino)
        {
            using (StreamWriter writer = new StreamWriter(archivoDestino))
            {
                // Escribir encabezados
                for (int i = 0; i < dgv.Columns.Count; i++)
                {
                    writer.Write(dgv.Columns[i].HeaderText);
                    if (i < dgv.Columns.Count - 1)
                        writer.Write(",");
                }
                writer.WriteLine();

                // Escribir filas
                foreach (DataGridViewRow fila in dgv.Rows)
                {
                    if (!fila.IsNewRow)
                    {
                        for (int i = 0; i < dgv.Columns.Count; i++)
                        {
                            writer.Write(fila.Cells[i].Value?.ToString());
                            if (i < dgv.Columns.Count - 1)
                                writer.Write(",");
                        }
                        writer.WriteLine();
                    }
                }
            }

            MessageBox.Show("Reporte exportado correctamente");
        }
    }
}

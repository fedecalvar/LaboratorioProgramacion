using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3_SEM1_2803
{
    internal class Productos
    {

        // propiedades para la tabla de Participantes
        public DataTable dtProductos { get; set; }
        public DataSet DS { get; set; }
        public OleDbDataAdapter DA { get; set; }

        public String Error = "";

        // constructor de la clase
        public Productos()
        {
            try
            {
                // conexión con la base 
                OleDbConnection cnn = new OleDbConnection();
                cnn.ConnectionString = "Provider=Microsoft.JET.OLEDB.4.0;Data Source=Productos.mdb";
                cnn.Open();
                // comando
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandType = CommandType.TableDirect;
                cmd.CommandText = "Productos";
                cmd.Connection = cnn;
                // data adapter
                DA = new OleDbDataAdapter(cmd);
                //dataset
                DS = new DataSet();
                // leer la tabla
                DA.Fill(DS, "Productos"); // se lee y guarda la tabla en el DataSet
                                              // clave primaria
                DataColumn[] dc = new DataColumn[1]; // arreglo de 1 elemento para la clave primaria
                dc[0] = DS.Tables["Productos"].Columns["Código"];
                DS.Tables["Productos"].PrimaryKey = dc;
                // commandbuilder
                OleDbCommandBuilder cb = new OleDbCommandBuilder(DA);
                //
                dtProductos = DS.Tables["Productos"];
            }
            catch (Exception ex)
            {
                Error = ex.Message;
            }
        }

        public void NuevoParticipante(int Codigo, String Nombre, String Descripcion, int Precio, int Stock)
        {
            try
            {
                DataRow nuevo = dtProductos.NewRow();
                nuevo["Código"] = Codigo;
                nuevo["Nombre"] = Nombre;
                nuevo["Descripción"] = Descripcion;
                nuevo["Precio"] = Precio;
                nuevo["Stock"] = Stock;
                dtProductos.Rows.Add(nuevo);
                DA.Update(dtProductos);
                
            }
            catch (Exception ex)
            {
                Error = ex.Message;
            }
        }
    }
}

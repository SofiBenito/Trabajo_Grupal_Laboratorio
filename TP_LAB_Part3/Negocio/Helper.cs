using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace TP_LAB_Part3.Negocio
{
    public class Helper
    {
        private static Helper instancia;
        private SqlConnection conexion;
        private SqlCommand command;

        private Helper()
        {
            command = new SqlCommand();
            conexion = new SqlConnection(Properties.Resources.CnnString);
        }
        public static Helper ObtenerInstancia()
        {
            if(instancia == null)
            {
                instancia = new Helper();
            }

            return instancia;
        }

        #region Obtener-Usuario
        public DataTable ObtenerUsuarios(string sp)
        {
            DataTable tabla = new DataTable();
            conexion.Open();
            command.Connection = conexion;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = sp;
            tabla.Load(command.ExecuteReader());
            command.Parameters.Clear();
            conexion.Close();
            return tabla;
        }
        #endregion

        #region Vista-EnStock
        public DataTable Vista_EnStock(string sp)
        {
            DataTable tabla = new DataTable();
            conexion.Open();
            command.Connection = conexion;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = sp;
            tabla.Load(command.ExecuteReader());
            command.Parameters.Clear();
            conexion.Close();
            return tabla;
        }
        #endregion

        #region All-Vehiculos Y All-Autopartes
        public DataTable All_Productos(string sp)
        {
            DataTable tabla = new DataTable();

            conexion.Open();
            command.Connection = conexion;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = sp;
            tabla.Load(command.ExecuteReader());
            command.Parameters.Clear();
            conexion.Close();

            return tabla;
        }
        #endregion

        #region Consulta1
        public DataTable Consulta1(string sp)
        {
            DataTable tabla = new DataTable();

            conexion.Open();
            command.Connection = conexion;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = sp;
            tabla.Load(command.ExecuteReader());
            command.Parameters.Clear();
            conexion.Close();

            return tabla;
        }
        #endregion

        #region Consulta2
        public DataTable Consulta2(string sp)
        {
            DataTable tabla = new DataTable();

            conexion.Open();
            command.Connection = conexion;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = sp;
            tabla.Load(command.ExecuteReader());
            command.Parameters.Clear();
            conexion.Close();

            return tabla;
        }
        #endregion

        #region Consulta3
        public DataTable Consulta3(string sp, string descripcion, long monto, int meses)
        {
            DataTable tabla = new DataTable();

            conexion.Open();
            command.Connection = conexion;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = sp;
            command.Parameters.AddWithValue("@descripcion", SqlDbType.VarChar).Value = descripcion;
            command.Parameters.AddWithValue("@monto", SqlDbType.BigInt).Value = monto;
            command.Parameters.AddWithValue("@meses", SqlDbType.Int).Value = meses;
            tabla.Load(command.ExecuteReader());
            command.Parameters.Clear();
            conexion.Close();

            return tabla;
        }
        #endregion

        #region Consulta4
        public DataTable Consulta4(string sp)
        {
            DataTable tabla = new DataTable();

            conexion.Open();
            command.Connection = conexion;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = sp;
            tabla.Load(command.ExecuteReader());
            command.Parameters.Clear();
            conexion.Close();

            return tabla;
        }
        #endregion

        #region Consulta5
        public DataTable Consulta5(string sp)
        {
            DataTable tabla = new DataTable();

            conexion.Open();
            command.Connection = conexion;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = sp;
            tabla.Load(command.ExecuteReader());
            command.Parameters.Clear();
            conexion.Close();

            return tabla;
        }
        #endregion

        #region Consulta6
        public DataTable Consulta6(string sp)
        {
            DataTable tabla = new DataTable();

            conexion.Open();
            command.Connection = conexion;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = sp;
            tabla.Load(command.ExecuteReader());
            command.Parameters.Clear();
            conexion.Close();

            return tabla;
        }
        #endregion

        #region Consulta7
        public DataTable Consulta7(string sp)
        {
            DataTable tabla = new DataTable();

            conexion.Open();
            command.Connection = conexion;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = sp;
            tabla.Load(command.ExecuteReader());
            command.Parameters.Clear();
            conexion.Close();

            return tabla;
        }
        #endregion

        #region Consulta8
        public DataTable Consulta8(string sp)
        {
            DataTable tabla = new DataTable();

            conexion.Open();
            command.Connection = conexion;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = sp;
            tabla.Load(command.ExecuteReader());
            command.Parameters.Clear();
            conexion.Close();

            return tabla;
        }
        #endregion

        #region Consulta10
        public DataTable Consulta10(string sp)
        {
            DataTable tabla = new DataTable();

            conexion.Open();
            command.Connection = conexion;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = sp;
            tabla.Load(command.ExecuteReader());
            command.Parameters.Clear();
            conexion.Close();

            return tabla;
        }
        #endregion
    }
}

using Biblioteca_clases.Dominio.Facturas_Ordenes;
using Biblioteca_clases.Dominio.Facturas_Ordenes.T_Detalles;
using Biblioteca_clases.Dominio.Productos;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_LAB_Part3
{
    public class Consulta_Negocio
    {
        public DataTable grilla()
        {
            DataTable dataTable = new DataTable();
            SqlConnection cnn = new SqlConnection(Properties.Resources.CnnString);
            SqlCommand cmd = new SqlCommand();
            cnn.Open();
            cmd.Connection = cnn;   
            cmd.CommandType=System.Data.CommandType.Text;
            cmd.CommandText = "select f.nro_factura 'Número Factura' ,Fecha,a.id_autoparte 'Codigo AutoParte',descripcion 'Descripción',stock 'Stock',stock_minimo,'$'+trim(str(df.precio_unitario))'Precio Unitario',c.id_cliente CodigoCliente,c.apellido+space(1)+c.nombre Cliente,v.id_vendedor CodigoVendedor,v.apellido+space(1)+v.nombre Vendedor from facturas f join detalles_facturas df on f.nro_factura=df.nro_factura join autopartes a on a.id_autoparte=df.id_autoparte join vendedores v on v.id_vendedor=f.id_vendedor join clientes c on c.id_cliente=f.id_cliente where stock>0";
            dataTable.Load(cmd.ExecuteReader());
            cnn.Close();
            cmd.Parameters.Clear();
            return dataTable;
        }



        public DataTable filtrar(string campo, string criterio, string filtro)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string consulta = "select f.nro_factura 'Número Factura' ,Fecha,a.id_autoparte 'Codigo AutoParte',descripcion 'Descripción',stock 'Stock',stock_minimo,'$'+trim(str(df.precio_unitario))'Precio Unitario',c.id_cliente CodigoCliente,c.apellido+space(1)+c.nombre Cliente,v.id_vendedor CodigoVendedor,v.apellido+space(1)+v.nombre Vendedor from facturas f join detalles_facturas df on f.nro_factura=df.nro_factura join autopartes a on a.id_autoparte=df.id_autoparte join vendedores v on v.id_vendedor=f.id_vendedor join clientes c on c.id_cliente=f.id_cliente where stock>0 and ";
                if (campo == "Número Factura")
                {
                    switch (criterio)
                    {
                        case "Mayor a":
                            consulta += "f.nro_factura > " + filtro;
                            break;
                        case "Menor a":
                            consulta += "f.nro_factura < " + filtro;
                            break;
                        default:
                            consulta += "f.nro_factura = " + filtro;
                            break;
                    }
                }
                else if (campo == "Descripción")
                {
                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += "descripcion like '" + filtro + "%' ";
                            break;
                        case "Termina con":
                            consulta += "descripcion like '%" + filtro + "'";
                            break;
                        default:
                            consulta += "descripcion like '%" + filtro + "%'";
                            break;
                    }
                }
                else if (campo == "Precio Unitario")
                {
                    switch (criterio)
                    {
                        case "Mayor a":
                            consulta += "df.precio_unitario > " + filtro;
                            break;
                        case "Menor a":
                            consulta += "df.precio_unitario < " + filtro;
                            break;
                        default:
                            consulta += "df.precio_unitario = " + filtro;
                            break;
                    }
                }
                else if(campo== "Stock")
                {
                    switch (criterio)
                    {
                        case "Mayor a":
                            consulta += "stock > " + filtro;
                            break;
                        case "Menor a":
                            consulta += "stock < " + filtro;
                            break;
                        default:
                            consulta += "stock = " + filtro;
                            break;
                    }
                }
                else if(campo== "Cliente")
                {
                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += "c.apellido like '" + filtro + "%' ";
                            break;
                        case "Termina con":
                            consulta += "c.apellido like '%" + filtro + "'";
                            break;
                        default:
                            consulta += "c.apellido like '%" + filtro + "%'";
                            break;
                    }
                }

                datos.settearConsulta(consulta);
                datos.ejecutarLectura();
                DataTable dataTable = new DataTable();
                SqlConnection cnn = new SqlConnection(Properties.Resources.CnnString);
                SqlCommand cmd = new SqlCommand();
                cnn.Open();
                cmd.Connection = cnn;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = consulta;
                dataTable.Load(cmd.ExecuteReader());
                cnn.Close();
                cmd.Parameters.Clear();
                return dataTable;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }



}

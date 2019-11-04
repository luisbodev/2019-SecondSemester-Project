using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDeAccesoDatos
{
    public class MantenimientoDetOrden
    {
        string sql;
        Conexion conn = new Conexion();
        SqlCommand cmd;
        string error;
        int res = 0;

        public DataTable mostrarDetalleOrden(string tabla, string p)
        {
            DataTable datos = new DataTable();
            SqlDataAdapter adapt;

            this.sql = "select * from " + tabla + " where noOrden =" + p;
            try
            {
                conn.abrir_conexion();
                adapt = new SqlDataAdapter(this.sql, conn.conex);
                adapt.Fill(datos);
            }
            catch (Exception e)
            {
                error = "Error " + e.ToString();
            }
            finally
            {
                conn.cerrar_conexion();
            }
            return datos;
        }
        //Mostrar DetalleOrden en Cajero
        public DataTable mostrarDetalleOrdenCaje(string p) {
            DataTable datos = new DataTable();
            SqlDataAdapter adapt;

            this.sql = "select d.idMenu as 'ID', m.nombre as 'Nombre', d.extra as 'Extra', d.cantidad as 'Cantidad', d.precioUnidad as 'Precio Uni', d.total as 'Total' " +
            "from detalle_orden d " +
            "inner join menu m on m.idMenu = d.idMenu " +
            "where noOrden = " + p;
            try
            {
                conn.abrir_conexion();
                adapt = new SqlDataAdapter(this.sql, conn.conex);
                adapt.Fill(datos);
            }
            catch (Exception e)
            {
                error = "Error " + e.ToString();
            }
            finally
            {
                conn.cerrar_conexion();
            }
            return datos;
        }
        //Agregar DetalleOrden
            public string agregarPlatoDetalle(DetalleOrden d)
            {
                cmd = new SqlCommand(string.Format("Insert into detalle_orden(noOrden, idMenu, extra, cantidad, precioUnidad, total) Values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", d.NoOrden, d.IdMenu,d.Extra,d.Cantidad,d.PrecioUnidad,d.Total), conn.conex);
                try
                {
                    conn.abrir_conexion();
                    res = cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    error = "Error " + e.Message;
                }
                finally
                {
                    conn.cerrar_conexion();
                }
                return "" + res;
            }
    }
}

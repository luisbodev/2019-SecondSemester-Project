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
    }
}

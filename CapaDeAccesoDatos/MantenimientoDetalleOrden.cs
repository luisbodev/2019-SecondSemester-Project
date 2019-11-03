using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDeAccesoDatos
{
    class MantenimientoDetalleOrden
    {
        string sql;
        Conexion conn = new Conexion();
        SqlCommand cmd;
        string error;
        int respuesta = 0;

        //Mostrar Informacion DetallePedido
        public DataTable mostrarDetallePedido(string tabla){
            DataTable datos = new DataTable();
            SqlDataAdapter adap;
            this.sql = "select * from " + tabla;
            
            try {
                conn.abrir_conexion();
                adap = new SqlDataAdapter(this.sql, conn.conex);
                adap.Fill(datos);
            }
            catch(Exception e) {
                error = "Error " + e.ToString();
            } 
            finally {
                conn.cerrar_conexion();
            }
            return datos;
                
        }
    }
}

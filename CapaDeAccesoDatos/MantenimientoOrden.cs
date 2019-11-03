using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDeAccesoDatos
{
    public class MantenimientoOrden
    {
        string sql;
        Conexion conn = new Conexion();
        SqlCommand cmd;
        string error;
        int respuesta = 0;

        //Mostrar Orden
        public DataTable mostrarOrden(string tabla, string p) {
            DataTable datos = new DataTable();
            SqlDataAdapter adap;
            if(p=="") {
                this.sql = "select * from " + tabla;
            }
            else {
                this.sql = "select * from" + tabla + "where noOrden like '%" + p + "%'";
            }
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

        //Mostrar Empleado
        public DataTable mostrarEmpleado(string tabla, string p) {
            DataTable datos = new DataTable();
            SqlDataAdapter adap;

            this.sql = "select * from " + tabla + " where idEmpleado =" + p;
            
            try {
                conn.abrir_conexion();
                adap = new SqlDataAdapter(this.sql, conn.conex);
                adap.Fill(datos);
            }
            catch(Exception e) {
                error = "Error" + e.ToString();
            }
            finally {
                conn.cerrar_conexion();
            }
            return datos;

        }
        //Mostrar Cliente
        public DataTable mostrarCliente(string tabla, string p)
        {
            DataTable datos = new DataTable();
            SqlDataAdapter adap;

            this.sql = "select * from " + tabla + " where idCliente =" + p;

            try
            {
                conn.abrir_conexion();
                adap = new SqlDataAdapter(this.sql, conn.conex);
                adap.Fill(datos);
            }
            catch (Exception e)
            {
                error = "Error" + e.ToString();
            }
            finally
            {
                conn.cerrar_conexion();
            }
            return datos;

        }
        public string agregarOrden(Orden o)
        {
            cmd = new SqlCommand(string.Format("Insert Into orden(idEmpleado, fecha, idCliente, total) Values('{0}', '{1}', '{2}', '{3}')", o.IdEmpleado, o.Fecha,o.IdCliente,o.Total), conn.conex);
        try{
           conn.abrir_conexion();
           respuesta = cmd.ExecuteNonQuery();
            }
        catch (Exception e){
                error = "Error " + e.Message;
            }
        finally{
                conn.cerrar_conexion();
            }
        return "" + respuesta;
        }

    }
}

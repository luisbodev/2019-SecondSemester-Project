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
        string error, res;
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
        //Mostrar Id Emp
        public string mostrarIdEmpleado(string tabla, string p)
        {

            this.sql = "select e.idEmpleado from " + tabla + " e inner join usuario u on u.idEmpleado = e.idEmpleado and u.usuario = '" + p + "'";
            try
            {
                conn.abrir_conexion();
                SqlCommand com = new SqlCommand(sql, conn.conex);
                res = com.ExecuteScalar().ToString();
            }
            catch (Exception e)
            {
                error = "Error " + e.Message;
            }
            finally
            {
                conn.cerrar_conexion();
            }
            return res;

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
        //Agregar Orden
       public string agregarOrden(Orden o)
        {
             cmd = new SqlCommand(string.Format("Insert Into orden(idEmpleado, fecha, idCliente, totalFinal) Values('{0}', '{1}', '{2}', '{3}')", o.IdEmpleado, o.Fecha, o.IdCliente, o.Total), conn.conex);
            
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
        //Seleccionar ultima orden
        public string mostrarUltOrden(string tabla)
        {

            this.sql = "select top 1 noOrden from " + tabla + " order by noOrden desc; ";
            try
            {
                conn.abrir_conexion();
                SqlCommand com = new SqlCommand(sql, conn.conex);
                res = com.ExecuteScalar().ToString();
            }
            catch (Exception e)
            {
                error = "Error " + e.Message;
            }
            finally
            {
                conn.cerrar_conexion();
            }
            return res;

        }
        //Agregar Total a orden
        public string totalFinalOrden(string t, string o) {
            cmd = new SqlCommand(string.Format("update orden set totalFinal = " + t + "where noOrden = " + o), conn.conex);

            try
            {
                conn.abrir_conexion();
                respuesta = cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                error = "Error " + e.Message;
            }
            finally
            {
                conn.cerrar_conexion();
            }
            return "" + respuesta;
        }

    }
}

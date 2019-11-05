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
        //Mostar noOrden de ultima orden realizada que este en proceso
        public string mostrarUltOrdenNoIni()
        {

            this.sql = "select top 1 o.noOrden from orden o where o.estado = 0";
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
        //Cambiar el estado de la orden
        public string modiEstadoOrden(string p, string es)
        {
            cmd = new SqlCommand(string.Format("update orden set estado = " + es + " where noOrden =" + p), conn.conex);

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
        //Seleccionar Detalle Orden en proceso
        public DataTable mostrarDetalleOrdPro(string p)
        {
            DataTable datos = new DataTable();
            SqlDataAdapter adap;

            this.sql = "select m.idMenu as 'ID', m.nombre as 'Nombre', m.descripcion as 'Descripción', d.extra as 'Extra', d.cantidad as 'Cantidad'" +
            "from orden o" +
            "inner join detalle_orden d on d.noOrden = o.noOrden and o.noOrden = " + p +
            "inner join menu m on m.idMenu = d.idMenu";
            try
            {
                conn.abrir_conexion();
                adap = new SqlDataAdapter(this.sql, conn.conex);
                adap.Fill(datos);
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

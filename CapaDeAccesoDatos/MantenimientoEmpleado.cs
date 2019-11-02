using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDeAccesoDatos
{
    public class MantenimientoEmpleado
    {
        String sql;
        Conexion conn = new Conexion();
        SqlCommand cmd;
        String error;
        int res = 0;


        public DataTable mostrar(String tabla, String p)
        {
            DataTable datos = new DataTable();
            SqlDataAdapter adapt;
            if (p == "")
                this.sql = "select * from " + tabla;
            else
                this.sql = "select * from " + tabla + " where nombreEmpleado like '%" + p + "%' or idEmpleado like '%" + p + "%'";

            try
            {
                conn.abrir_conexion();
                adapt = new SqlDataAdapter(this.sql, conn.conex);
                adapt.Fill(datos);
            }
            catch (Exception e)
            {
                error = "Error" + e.ToString();
            }
            finally
            {
                conn.cerrar_conexion();
            }
            return datos;//Para retornar Datos

        }


        //Insertar datos
        public string agregar(Empleado e)//Creamos el objeto alumno = a 
        {
            cmd = new SqlCommand(string.Format("Insert Into empleado(nombreEmpleado, ApellidoEmpleado, duiEmpleado, cargo) values('{0}','{1}','{2}','{3}')",
            e.NombreEmpleado, e.ApellidoEmpleado, e.DuiEmpleado, e.Cargo), conn.conex);

            try
            {
                conn.abrir_conexion();
                res = cmd.ExecuteNonQuery(); //Ejecutar la consulta a el SQL //Si hace la incersion va valer 1 y si no la hace va valer 0
            }
            catch (Exception a)
            {
                error = "Error" + a.Message;
                return error;
            }
            finally
            {
                conn.cerrar_conexion();
            }
            return "" + res;
        }


        public string modificar(Empleado e)
        {
            cmd = new SqlCommand(string.Format("Update empleado set nombreEmpleado = '{0}', ApellidoEmpleado = '{1}', duiEmpleado = '{2}', cargo = '{3}' where idEmpleado ='{4}'",
                e.NombreEmpleado, e.ApellidoEmpleado, e.DuiEmpleado, e.Cargo, e.IdEmpleado ), conn.conex);

            try
            {
                conn.abrir_conexion();
                res = cmd.ExecuteNonQuery(); //Ejecutar la consulta a el SQL //Si hace la incersion va valer 1 y si no la hace va valer 0
            }
            catch (Exception a)
            {
                error = "Error" + a.Message;
                return error;
            }
            finally
            {
                conn.cerrar_conexion();
            }
            return "" + res;
        }

        public string eliminar(Empleado e)
        {
            cmd = new SqlCommand(string.Format("Delete from empleado where idEmpleado = '{0}'", e.IdEmpleado), conn.conex);

            try
            {
                conn.abrir_conexion();
                res = cmd.ExecuteNonQuery(); //Ejecutar la consulta a el SQL //Si hace la incersion va valer 1 y si no la hace va valer 0
            }
            catch (Exception a)
            {
                error = "Error" + a.Message;
                return error;
            }
            finally
            {
                conn.cerrar_conexion();
            }
            return "" + res;


        }







    }
}

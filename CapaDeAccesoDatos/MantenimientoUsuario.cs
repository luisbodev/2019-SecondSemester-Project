using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDeAccesoDatos
{
    public class MantenimientoUsuario
    {

        //--------------
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
                this.sql = "select * from " + tabla + " where usuario like '%" + p + "%'";

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

        ///-----------------------------<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>-------------------------------------<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        //Insertar datos
        public string agregarUsuario(Usuario u)//Creamos el objeto alumno = a 
        {
            cmd = new SqlCommand(string.Format("Insert Into usuario(usuario, idEmpleado, contrasena, rol)  values('{0}','{1}','{2}','{3}')",
            u.Nusuario, u.IdEmpleado,  u.Contrasena, u.Rol), conn.conex);

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


        public string modificar(Usuario u)
        {
            cmd = new SqlCommand(string.Format("Update usuario set usuario = '{0}', contrasena = '{1}', rol = '{2}' where idEmpleado ='{3}'",
                u.Nusuario, u.Contrasena, u.Rol, u.IdEmpleado), conn.conex);

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

        public string eliminar(Usuario u)
        {
            cmd = new SqlCommand(string.Format("Delete from usuario where usuario = '{0}'", u.Nusuario), conn.conex);

            try
            {
                conn.abrir_conexion();
                res = cmd.ExecuteNonQuery(); //Ejecutar la consulta a el SQL //Si hace la insersion va valer 1 y si no la hace va valer 0
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















        //-----------

    }
}

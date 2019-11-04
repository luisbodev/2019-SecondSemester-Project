using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDeAccesoDatos
{
   public class MantenimientoCliente
    {
        //Agregar Menú
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
                this.sql = "select * from " + tabla + " where nombre like '%" + p + "%' or idCliente like '%" + p + "%'";

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
        public string agregar(Cliente c)//Creamos el objeto  = c
        {
            cmd = new SqlCommand(string.Format("Insert Into cliente(nombre, apellido, correo, telefono,dui) values('{0}','{1}','{2}','{3}','{4}')",
           c.Nombre, c.Apellido, c.Correo, c.Telefono, c.Dui), conn.conex);

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


        public string modificar(Cliente c)
        {
            cmd = new SqlCommand(string.Format("Update cliente set nombre = '{0}',apellido = '{1}',correo = '{2}',telefono = '{3}',dui = '{4}' where idCliente ='{5}'",
                c.Nombre, c.Apellido, c.Correo, c.Telefono, c.Dui, c.IdCliente), conn.conex);

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

        public string eliminar(Cliente c)
        {
            cmd = new SqlCommand(string.Format("Delete from cliente where idCliente = '{0}'", c.IdCliente), conn.conex);

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
    
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDeAccesoDatos
{
    public class MantenimientoCategoria
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
                this.sql = "select * from " + tabla + " where nombreCate like '%" + p + "%' or idCategoria like '%" + p + "%'";

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
        public string agregar(categoria e)//Creamos el objeto alumno = a 
        {
            cmd = new SqlCommand(string.Format("Insert Into categoria(nombreCate) values('{0}')",
              e.Categorie), conn.conex);

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


        public string modificar(categoria e)
        {
            cmd = new SqlCommand(string.Format("Update categoria set nombreCate = '{0}' where idCategoria ='{1}'",
                e.Categorie, e.IdCategoria), conn.conex);

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

        public string eliminar(categoria e)
        {
            cmd = new SqlCommand(string.Format("Delete from categoria where idCategoria = '{0}'", e.IdCategoria), conn.conex);

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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDeAccesoDatos
{
    public class MantenimientoMenu
    {

        //Agregar Menú
        public class MantenimientoAlumno
        {
            string sql;
            Conexion conn = new Conexion();
            SqlCommand cmd;
            string error;
            int respuesta = 0;


            //Mostrar Menú--------------------------------------------------------------------
            public DataTable mostrarMenu(string tabla, string p)
            {
                DataTable datos = new DataTable();
                SqlDataAdapter adap;
                if (p == "")
                    this.sql = "select * from " + tabla;
                else
                    this.sql = "select * from " + tabla + " where Nombre like '%" + p + "%' or Apellido like '%" + p + "%'";
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

            //Agregar Menú

            public string agregar(Menu m)
            {
                cmd = new SqlCommand(string.Format("Insert Into menu(descripcion, precio, nombre) Values('{0}', '{1}', '{2}')", m.Descipcion, m.Precio, m.Nombre), conn.conex);
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

            //Modificar Menú --------------------------------------------

            public string modificar(Menu m)
            {
                cmd = new SqlCommand(string.Format("Update alumnos set descripcion = '{0}', precio = '{1}', nombre = '{2}' where idMenu= '{3}'", m.Descipcion, m.Precio, m.Nombre, m.IdMenu), conn.conex);
                try
                {
                    conn.abrir_conexion();
                    respuesta = cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    error = "Error " + e.Message;
                    return error;
                }
                finally
                {
                    conn.cerrar_conexion();
                }
                return "" + respuesta;
            }

            public string eliminar(Menu m)
            {
                cmd = new SqlCommand(string.Format("Delete from Alumnos where Id = '{0}'", m.IdMenu), conn.conex);
                try
                {
                    conn.abrir_conexion();
                    respuesta = cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    error = "Error " + e.Message;
                    return error;
                }
                finally
                {
                    conn.cerrar_conexion();
                }
                return "" + respuesta;
            }
        }
    }
}

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
                    this.sql = "select * from " + tabla + " where nombre like '%" + p + "%' or idMenu like '%" + p + "%'";// or Apellido like '%" + p + "%'
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
                //Mostrar MenuOrden
                public DataTable mostrarMenuOrden(string tabla, string p)
                {
                    DataTable datos = new DataTable();
                    SqlDataAdapter adap;
                    if (p == "")
                    {
                        this.sql = "select m.idMenu as 'ID', m.nombre as 'Nombre', m.descripcion as 'Descripción', m.precio as 'Precio', c.nombreCate as 'Categoría'" +
                        "from " + tabla + " m " +
                        "inner join categoria c on c.idCategoria = m.idCategoria";
                    }
                    else {
                        this.sql = "select m.idMenu as 'ID', m.nombre as 'Nombre', m.descripcion as 'Descripción', m.precio as 'Precio', c.nombreCate as 'Categoría'" +
                        "from " + tabla + " m " +
                        "inner join categoria c on c.idCategoria = m.idCategoria" +
                        "where m.nombre = " + p;
                    }
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

        public string agregarMenu(Menu m)
                {
                    cmd = new SqlCommand(string.Format("Insert Into menu(nombre, descripcion, precio, idcategoria) Values('{0}', '{1}', '{2}', '{3}')", m.Nombre, m.Descipcion, m.Precio, m.Categoria), conn.conex);
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

            public string modificarMenu(Menu m)
            {
                cmd = new SqlCommand(string.Format("Update menu set nombre = '{0}', descripcion = '{1}', precio = '{2}', idCategoria = '{3}' where idMenu= '{4}'", m.Nombre, m.Descipcion, m.Precio,  m.Categoria,m.IdMenu), conn.conex);
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

            public string eliminarMenu(Menu m)
            {
                cmd = new SqlCommand(string.Format("Delete from menu where idMenu = '{0}'", m.IdMenu), conn.conex);
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


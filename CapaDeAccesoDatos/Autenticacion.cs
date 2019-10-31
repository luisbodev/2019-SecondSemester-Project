using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace CapaDeAccesoDatos
{
     public class Autenticacion
     {



        Conexion conn = new Conexion();
        //SqlCommand cmd;
        string error;

     //Proceso para saber que tipo de usuario es


        public string tipousuario(string usuario)
        {
            
            
            string cadena = "";
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter();
            sda = new SqlDataAdapter("select * from usuario where usuario= '" + usuario + "'", conn.conex);
            sda.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                if (dt.Rows[0][3].ToString() == "admi")
                {
                    cadena = "admi";
                    conn.abrir_conexion();
                    return cadena;
                }
                else if (dt.Rows[0][3].ToString() == "caje")
                {
                    cadena = "caje";
                    conn.cerrar_conexion();
                    return cadena;
                }
                else if (dt.Rows[0][3].ToString() == "chef")
                {
                    cadena = "chef";
                    conn.cerrar_conexion();
                    return cadena;
                }
            }
            conn.cerrar_conexion();
            return cadena;
        }

        // Autenticar el usuario y la contraseña




        public bool verificar(string usuario, string contrasena)
        {
            

            SqlConnection con = new SqlConnection();
            try
            {
                conn.abrir_conexion();
                //conn.abrir_conexion();
                SqlCommand cmd = new SqlCommand(string.Format("select * from usuario where usuario='" + usuario + "'" + " and " + "contrasena='" + contrasena + "'"), conn.conex);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    conn.cerrar_conexion();
                    return true;
                }
                else
                {
                    conn.cerrar_conexion();
                    return false;
                }


                

       
            }
            catch (Exception e)
            {
                error = "Error " + e.ToString();
                conn.cerrar_conexion();
                return false;
            }

        }
    }

}

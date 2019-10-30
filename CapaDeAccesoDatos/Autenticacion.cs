using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDeAccesoDatos
{
    /* public class Autenticacion
     {
         public string tipousuario(string usuario)
         {
             SqlConnection con = new SqlConnection(conexion.cadenaconexion());
             con.Open();
             string cadena = "";
             DataTable dt = new DataTable();
             SqlDataAdapter sda = new SqlDataAdapter();
             sda = new SqlDataAdapter("select * from usuario where usuario= '" + usuario + "'", con);
             sda.Fill(dt);
             if (dt.Rows.Count == 1)
             {
                 if (dt.Rows[0][3].ToString() == "admin")
                 {
                     cadena = "admin";
                     con.Close();
                     return cadena;
                 }
                 else if (dt.Rows[0][3].ToString() == "prof")
                 {
                     cadena = "prof";
                     con.Close();
                     return cadena;
                 }
                 else if (dt.Rows[0][3].ToString() == "alum")
                 {
                     cadena = "alum";
                     con.Close();
                     return cadena;
                 }
             }
             con.Close();
             return cadena;
         }

         public int verificar(string usuario, string contrasena)
         {
             int resultado = -1;

             SqlConnection con = new SqlConnection(conexion.cadenaconexion());
             try
             {
                 con.Open();
                 SqlCommand cmd = new SqlCommand(string.Format("select * from usuario where usuario='" + usuario + "'" + " and " + "contrasena='" + contrasena + "'"), con);
                 SqlDataReader dr = cmd.ExecuteReader();
                 while (dr.Read())
                 {

                     resultado = 1;
                 }
                 if (resultado == -1)
                 {
                     MessageBox.Show("Lo sentimos el Usuario o contraseña son incorrectos");
                 }
                 con.Close();
                 return resultado;
             }
             catch (SqlException error)
             {
                 MessageBox.Show(error.Message);
                 con.Close();
                 return -1;
             }

         }
     }*/
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDeAccesoDatos
{
    class Conexion
    {
        //public SqlConnection conex = new SqlConnection("Data source =DESKTOP-4CJHEF7\\SQLEXPRESS; Initial catalog = ComidaRapida; Integrated Security=True");
        public SqlConnection conex = new SqlConnection("Data source =DESKTOP-2BQP3OM; Initial catalog = ComidaRapida; Integrated Security=True");

        public void abrir_conexion()
        {
            if (conex.State == ConnectionState.Closed)
                conex.Open();
        }

        public void cerrar_conexion()
        {
            if (conex.State == ConnectionState.Open)
                conex.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDeAccesoDatos;

namespace Clases
{
  public  class TransacCliente
    {
        MantenimientoCliente obj = new MantenimientoCliente();


        public DataTable mostrar_Cliente()
        {
            return obj.mostrar("cliente", "");
        }

        public DataTable buscar_Cliente(string p)
        {
            return obj.mostrar("cliente", p); //Select * from where>>>>>>>>>>>>>>>>>>>>>>>>alumnos

        }

        public string agregar_Cliente(string nombre, string apellido, string correo, string telefono, string dui)
        {
            Cliente c = new Cliente(1, nombre, apellido, correo, telefono, dui);//si no fuera entero el id,, tendriamos que agregar comillas ""
            return obj.agregar(c);
        }

        public string modificar_Cliente(string idCliente, string nombre, string apellido, string correo, string telefono, string dui)
        {
            Cliente c = new Cliente(int.Parse(idCliente), nombre, apellido, correo, telefono, dui);
            return obj.modificar(c);
        }


        public string eliminar_Cliente(string idCliente)
        {
            Cliente c = new Cliente(int.Parse(idCliente),"", "", "", "", "");
            return obj.eliminar(c);
        }
    }

}
   

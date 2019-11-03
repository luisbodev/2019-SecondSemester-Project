using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDeAccesoDatos;

namespace Clases
{
    public class TransacEmpleado
    {
        MantenimientoEmpleado obj = new MantenimientoEmpleado();

        public DataTable mostrar_Empleado()
        {
            return obj.mostrar("empleado", "");//select * from>>>>>>>>>>>>>>>>>>>>>>>>>>alumnos
        }

        public DataTable buscar_Empleado(string p)
        {
            return obj.mostrar("empleado", p); //Select * from where>>>>>>>>>>>>>>>>>>>>>>>>alumnos

        }

        public string agregar_Empleado(string nombreEmpleado, string apellidoEmpleado, string duiEmpleado, string cargo)
        {
            Empleado a = new Empleado(1, nombreEmpleado, apellidoEmpleado, duiEmpleado, cargo);//si no fuera entero el id,, tendriamos que agregar comillas ""
            return obj.agregar(a);
        }

        public string modificar_Empleado(string idEmpleado, string nombreEmpleado, string apellidoEmpleado, string duiEmpleado, string cargo)
        {
            Empleado a = new Empleado(int.Parse(idEmpleado), nombreEmpleado, apellidoEmpleado, duiEmpleado, cargo);
            return obj.modificar(a);
        }


        public string eliminar_Empleado(string idEmpleado)
        {
            Empleado a = new Empleado(int.Parse(idEmpleado),"", "", "", "");
            return obj.eliminar(a);
        }
    }
}

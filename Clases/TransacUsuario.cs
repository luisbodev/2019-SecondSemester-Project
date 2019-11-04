using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDeAccesoDatos;

namespace Clases
{
    public class TransacUsuario
    {
        MantenimientoUsuario obj = new MantenimientoUsuario();
        MantenimientoEmpleado objE = new MantenimientoEmpleado();

        public DataTable mostrar_Usuario()
        {
            return obj.mostrar("usuario", "");//select * from>>>>>>>>>>>>>>>>>>>>>>>>>>alumnos
        }

        public DataTable buscar_Usuario(string p)
        {
            return obj.mostrar("usuario", p); //Select * from where>>>>>>>>>>>>>>>>>>>>>>>>alumnos

        }

        public string agregar_Usuario(string Nusuario, string idEmpleado, string contrasena, string rol)
        {
            Usuario u = new Usuario(Nusuario, int.Parse(idEmpleado), contrasena, rol);//si no fuera entero el id,, tendriamos que agregar comillas ""
            return obj.agregarUsuario(u);
        }

        public string modificar_Usuario(string Nusuario, string idEmpleado, string contrasena, string rol)
        {
            Usuario a = new Usuario(Nusuario, int.Parse(idEmpleado), contrasena, rol);
            return obj.modificar(a);
        }

       


        public string eliminar_Usuario(string Usuario)
        {
            Usuario a = new Usuario(Usuario,0, "", "");
            return obj.eliminar(a);
        }
    }
}

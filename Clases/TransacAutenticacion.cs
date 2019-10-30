using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDeAccesoDatos;

namespace Clases
{
    public class TransacAutenticacion
    {
        

        Autenticacion Obj = new Autenticacion();
        

        public string loginUser(string usuario)
        {
            return Obj.tipousuario(usuario); //Tipo de usuario---------------------------------
        }

        public bool validacion(string usuario, string contrasena)
        {
            return Obj.verificar(usuario, contrasena); // resultado 1 o 0
        }
       
         

    }
}

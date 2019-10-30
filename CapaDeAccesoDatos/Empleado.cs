using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeAccesoDatos
{
    class Empleado
    {


        private int integer;
        private string duiEmpleado;
        private string cargo;
        private string nombre;

        public int Integer
        {
            get
            {
                return integer;
            }

            set
            {
                integer = value;
            }
        }

        public string DuiEmpleado
        {
            get
            {
                return duiEmpleado;
            }

            set
            {
                duiEmpleado = value;
            }
        }

        public string Cargo
        {
            get
            {
                return cargo;
            }

            set
            {
                cargo = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }
    }
}

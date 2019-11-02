using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeAccesoDatos
{
    public class Empleado
    {



        private int idEmpleado;
        private string nombreEmpleado;
        private string apellidoEmpleado;
        private string duiEmpleado;
        private string cargo;

        public int IdEmpleado
        {
            get
            {
                return idEmpleado;
            }

            set
            {
                idEmpleado = value;
            }
        }

        public string NombreEmpleado
        {
            get
            {
                return nombreEmpleado;
            }

            set
            {
                nombreEmpleado = value;
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

        public string ApellidoEmpleado
        {
            get
            {
                return apellidoEmpleado;
            }

            set
            {
                apellidoEmpleado = value;
            }
        }

        public Empleado()
        {

        }

        public Empleado(int pIdEmpleado, string pNombreEmpleado, string pApellidoEmpleado, string pDuiEmpleado, string pCargo)
        {
            this.IdEmpleado = pIdEmpleado;
            this.NombreEmpleado = pNombreEmpleado;
            this.ApellidoEmpleado = pApellidoEmpleado;
            this.DuiEmpleado = pDuiEmpleado;
            this.Cargo = pCargo;     
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeAccesoDatos
{
   public class Cliente
    {
        private int idCliente;
        private string nombre;
        private string apellido;
        private string correo;
        private string telefono;
        private string dui;

        public int IdCliente
        {
            get
            {
                return idCliente;
            }

            set
            {
                idCliente = value;
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

        public string Apellido
        {
            get
            {
                return apellido;
            }

            set
            {
                apellido = value;
            }
        }

        public string Correo
        {
            get
            {
                return correo;
            }

            set
            {
                correo = value;
            }
        }

        public string Telefono
        {
            get
            {
                return telefono;
            }

            set
            {
                telefono = value;
            }
        }

        public string Dui
        {
            get
            {
                return dui;
            }

            set
            {
                dui = value;
            }
        }
        public Cliente()
        {

        }
        public Cliente(int pidCliente, string pnombre, string papellido, string pcorreo, string ptelefono, string pdui)
        {
            this.IdCliente = pidCliente;
            this.Nombre = pnombre;
            this.Apellido = papellido;
            this.Correo = pcorreo;
            this.Telefono = ptelefono;
            this.Dui = pdui;

        }
    }
}

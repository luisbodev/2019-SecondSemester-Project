using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeAccesoDatos
{
    public class Orden
    {
        private int noOrden;
        private int idEmpleado;
        private DateTime fecha;
        private int idCliente;
        private double total;

        public int NoOrden
        {
            get
            {
                return noOrden;
            }

            set
            {
                noOrden = value;
            }
        }

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

        public DateTime Fecha
        {
            get
            {
                return fecha;
            }

            set
            {
                fecha = value;
            }
        }

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

        public double Total
        {
            get
            {
                return total;
            }

            set
            {
                total = value;
            }
        }

   

        public Orden() {

        }

        public Orden(int pNoOrden, int pIdEmpleado, DateTime pFecha, int pIdCliente, double pTotal) {
            this.NoOrden = pNoOrden;
            this.IdEmpleado = pIdEmpleado;
            this.Fecha = pFecha;
            this.IdCliente = pIdCliente;
            this.Total = pTotal;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeAccesoDatos
{
    class DetalleOrden
    {
        private int noOrden;
        private int idMenu;
        private string extra;
        private int cantidad;
        private double precioUnidad;
        private double descuento;
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

        public int IdMenu
        {
            get
            {
                return idMenu;
            }

            set
            {
                idMenu = value;
            }
        }

        public string Extra
        {
            get
            {
                return extra;
            }

            set
            {
                extra = value;
            }
        }

        public int Cantidad
        {
            get
            {
                return cantidad;
            }

            set
            {
                cantidad = value;
            }
        }

        public double PrecioUnidad
        {
            get
            {
                return precioUnidad;
            }

            set
            {
                precioUnidad = value;
            }
        }

        public double Descuento
        {
            get
            {
                return descuento;
            }

            set
            {
                descuento = value;
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
        //Metodo Constructor
        public void DetalleORden() {

        }

        public DetalleOrden(int pNoOrden, int pIdMenu, string pExtra, int pCantidad, double pPrecioUnidad, double pDescuento, double pTotal) {
            this.NoOrden = pNoOrden;
            this.IdMenu = pIdMenu;
            this.Extra = pExtra;
            this.Cantidad = pCantidad;
            this.PrecioUnidad = pPrecioUnidad;
            this.Descuento = pDescuento;
            this.Total = pTotal;
        }
    }
}

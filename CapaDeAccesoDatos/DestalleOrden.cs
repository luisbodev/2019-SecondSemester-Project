using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeAccesoDatos
{
    public class DestalleOrden
    {
        private int noOrden;
        private int idMenu;
        private string extra;
        private int cantidad;
        private double precioUnidad;
        private double descuento;
        private int idCategoria;

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

        public int IdCategoria
        {
            get
            {
                return idCategoria;
            }

            set
            {
                idCategoria = value;
            }
        }

        public DestalleOrden() {

        }

    }
}

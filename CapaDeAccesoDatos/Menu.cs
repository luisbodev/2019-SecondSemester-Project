using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeAccesoDatos
{
    public class Menu
    {
  

        private int idMenu;
        private string nombre;
        private string descipcion;
        private double precio;
        

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

        public string Descipcion
        {
            get
            {
                return descipcion;
            }

            set
            {
                descipcion = value;
            }
        }

        public double Precio
        {
            get
            {
                return precio;
            }

            set
            {
                precio = value;
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


        public Menu()
        {

        }

        public Menu(int pIdMenu, string pNombre, string pDescripcion, double pPrecio)
        {
            this.IdMenu = pIdMenu;
            this.Descipcion = pDescripcion;
            this.Precio = pPrecio;
            this.Nombre = pNombre;
        }









    }
}

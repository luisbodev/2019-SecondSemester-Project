using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDeAccesoDatos;

namespace Clases
{
    public class TransacMenu
    {
        MantenimientoMenu obje = new MantenimientoMenu();


        public DataTable mostrar_menu()
        {
            return obje.mostrarMenu("menu", "");
        }

        //Buscar menu

        public DataTable buscar_menu(string p)
        {
            return obje.mostrarMenu("menu", p);
        }

        //Agregar menu
        public string agregar_menu(string nombre,string descripcion, string precio)
        {
            Menu m = new Menu(1, nombre, descripcion, double.Parse(precio));
            return obje.agregarMenu(m);
        }

        //Modificar menu

        public string modificar_menu(string idMenu, string nombre, string descripcion, string precio)
        {
            Menu m = new Menu(int.Parse(idMenu), nombre, descripcion, double.Parse(precio));
            return obje.modificarMenu(m);
        }

        //Eliminar menu

        public string eliminar_menu(string idMenu)
        {
            Menu m = new Menu(int.Parse(idMenu), "", "",0.0);
            return obje.eliminarMenu(m);
        }



    }
}


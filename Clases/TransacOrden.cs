using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDeAccesoDatos;

namespace Clases
{
    public class TransacOrden
    {
        MantenimientoOrden obje = new MantenimientoOrden(); 

        public DataTable mostrar_Orden() {
            return obje.mostrarOrden("orden", "");
        }
        //Mostrar Empleado
        public DataTable mostrar_Empleado()
        {
            return obje.mostrarEmpleado("empleado", "");
        }
        public DataTable mostrar_EmpleadoEspecifico(string p) {
            return obje.mostrarEmpleado("empleado", p);
        }
        //Mostrar Cliente
        public DataTable mostrar_Cliente()
        {
            return obje.mostrarCliente("cliente", "");
        }
        public DataTable mostrar_ClienteEspecifico(string p)
        {
            return obje.mostrarCliente("cliente", p);
        }

        //Agregar Orden
        public string agrega_orden(string IdEmpleado, string Fecha, string IdCliente, string Total) {
            Orden o = new Orden(1, int.Parse(IdEmpleado), DateTime.Parse(Fecha), int.Parse(IdCliente), double.Parse(Total));
            return obje.agregarOrden(o);
        }

        
    }
}

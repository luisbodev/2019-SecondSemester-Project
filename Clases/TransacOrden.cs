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
        //Mostrar idEmpleado
        public string mostrar_IdEmpleado(string p) {
            return obje.mostrarIdEmpleado("empleado", p);
        }

        //Agregar Orden
        public string agrega_orden(string IdEmpleado, string Fecha, string IdCliente, string totalFinal) {
            Orden o = new Orden(1, int.Parse(IdEmpleado), DateTime.Parse(Fecha), int.Parse(IdCliente), double.Parse(totalFinal));
            return obje.agregarOrden(o);
        }
        //Seleccionar ultima orden
        public string mostrar_ultOrden() {
            return obje.mostrarUltOrden("orden");
        }
        //Seleccionar estado
        public string mostrar_UltOrdenEsta(string p) {
            return obje.mostrarUltOrdenEsta(p);
        }
        //Agregar total a orden
        public string total_FinalOrden(string t, string o) {
            return obje.totalFinalOrden(t, o);
        }
        //Muestra 
        public string mostrar_UltOrdenNoIni() {
            return obje.mostrarUltOrdenNoIni();
        }
        //Cambia el estado de la orden
        public string modi_estadoOrden(string p, string es) {
            return obje.modiEstadoOrden(p, es);
        }
        
    }
}

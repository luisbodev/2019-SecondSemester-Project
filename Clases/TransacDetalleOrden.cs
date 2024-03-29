﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDeAccesoDatos;

namespace Clases
{
    public class TransacDetalleOrden
    {
        MantenimientoDetOrden obj = new MantenimientoDetOrden();

        
        public DataTable mostrar_detOrdenEspe(string p) {
            return obj.mostrarDetalleOrden("detalle_orden", p);
        }
        public DataTable mostrar_DetalleOrdenCaje(string p) {
            return obj.mostrarDetalleOrdenCaje(p);
        }
        //Agregar Detalle Plato
        public string agregar_platoDetalle(string noOrden, string idMenu, string extra, string cantidad, string precioUnidad, string total) {
            DetalleOrden d = new DetalleOrden(int.Parse(noOrden), int.Parse(idMenu), extra, int.Parse(cantidad), double.Parse(precioUnidad), double.Parse(total));
            return obj.agregarPlatoDetalle(d);
        }
        //Seleccionar Detalle Orden en proceso
        public DataTable mostrar_detalleOrdPro(string p)
        {
            return obj.mostrarDetalleOrdPro(p);
        }
        //Modificar detalle orden
        public string modificar_DetalleOrden(string noOrden, string idMenu, string extra, string cantidad, string precioUnidad, string total) {
            DetalleOrden d = new DetalleOrden(int.Parse(noOrden), int.Parse(idMenu), extra, int.Parse(cantidad), double.Parse(precioUnidad), double.Parse(total));
            return obj.modificarDetalleOrden(d);
        }
        //Eliminar detalle orden
        public string eliminar_Detalle(string noOrden, string idMenu) {
            DetalleOrden d = new DetalleOrden(int.Parse(noOrden), int.Parse(idMenu), "", 0, 0.0, 0.0);
            return obj.eliminarDetalle(d);
        }
        //Actualizar Detalle Orden total
        public string actualizar_Det(string t, string id, string o) {
            return obj.actualizarDeta(t, id, o);
        }
    }
}

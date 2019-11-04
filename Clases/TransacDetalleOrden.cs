using System;
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

        public DataTable mostrar_detalleOrden() {
            return obj.mostrarDetalleOrden("detalle_orden", "");
        }

        public DataTable mostrar_detOrdenEspe(string p) {
            return obj.mostrarDetalleOrden("detalle_orden", p);
        }
    }
}

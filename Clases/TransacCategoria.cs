using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDeAccesoDatos;

namespace Clases
{
    public class TransacCategoria
    {
        MantenimientoCategoria obj = new MantenimientoCategoria();


        public DataTable mostrar_Cat()
        {
            return obj.mostrar("categoria", "");//select * from>>>>>>>>>>>>>>>>>>>>>>>>>>alumnos
        }

        public DataTable buscar_cat(string p)
        {
            return obj.mostrar("categoria", p); //Select * from where>>>>>>>>>>>>>>>>>>>>>>>>alumnos

        }

        public string agregar_cat(string categorie)
        {
            categoria a = new categoria(1, categorie);//si no fuera entero el id,, tendriamos que agregar comillas ""
            return obj.agregar(a);
        }

        public string modificar_cat(string idCategoria, string categorie)
        {
            categoria a = new categoria(int.Parse(idCategoria),  categorie);
            return obj.modificar(a);
        }


        public string eliminar_cat(string idCategoria)
        {
            categoria a = new categoria(int.Parse(idCategoria), "");
            return obj.eliminar(a);
        }

        public DataTable Listar_Cat(string categorie)
        {
           
            return obj.ListarCategorias("categoria");
        }
    }
}

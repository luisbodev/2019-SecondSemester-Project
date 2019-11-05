using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeAccesoDatos
{
    public class categoria
    {
        private int idCategoria;
        private string categorie;

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

        public string Categorie
        {
            get
            {
                return categorie;
            }

            set
            {
                categorie = value;
            }
        }

        public categoria()
        {

        }

        public categoria(int pidCategoria, string pCategorie)
        {
            this.IdCategoria = pidCategoria;
            this.Categorie = pCategorie;
        }
    }
}

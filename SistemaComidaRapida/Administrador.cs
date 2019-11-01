using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaComidaRapida
{
    public partial class frmAdministrador : Form
    {
        
        public frmAdministrador()
        {
            InitializeComponent();
        }

        private void btnVerMenu_Click(object sender, EventArgs e)
        {
            frmDatosMenu dmn = new frmDatosMenu();//Mostrar Menu
            dmn.Show();

        }

        private void menuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmDatosMenu dmn = new frmDatosMenu();//Mostrar Menu
            dmn.Show();

        }
    }
}

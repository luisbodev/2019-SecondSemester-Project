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

        

       

        private void menuToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            frmDatosMenu crudmenu = new frmDatosMenu();//Mostrar Crud Menu  
            crudmenu.MdiParent = this;
            crudmenu.Show();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que quiere cerrar Sesión?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) this.Close();
        }

        private void labelUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}
